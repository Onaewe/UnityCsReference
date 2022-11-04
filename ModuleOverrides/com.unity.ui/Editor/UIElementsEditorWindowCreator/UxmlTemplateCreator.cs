// Unity C# reference source
// Copyright (c) Unity Technologies. For terms of use, see
// https://unity3d.com/legal/licenses/Unity_Reference_Only_License

using System;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UIElements;

namespace UnityEditor.UIElements
{
    static partial class UIElementsTemplate
    {
        private static string GetCurrentFolder()
        {
            string filePath;
            if (Selection.assetGUIDs.Length == 0)
            {
                // No asset selected.
                filePath = "Assets";
            }
            else
            {
                // Get the path of the selected folder or asset.
                filePath = AssetDatabase.GUIDToAssetPath(Selection.assetGUIDs[0]);

                // Get the file extension of the selected asset as it might need to be removed.
                string fileExtension = Path.GetExtension(filePath);
                if (fileExtension != "")
                {
                    filePath = Path.GetDirectoryName(filePath);
                }
            }

            return filePath;
        }

        [MenuItem("Assets/Create/UI Toolkit/UI Document", false, 610, false)]
        private static void CreateUXMLAsset()
        {
            var folder = GetCurrentFolder();
            var path = AssetDatabase.GenerateUniqueAssetPath(folder + "/NewUXMLTemplate.uxml");
            var contents = CreateUXMLTemplate(folder);
            var icon = EditorGUIUtility.IconContent<VisualTreeAsset>().image as Texture2D;
            ProjectWindowUtil.CreateAssetWithContent(path, contents, icon);
        }

        public static string CreateUXMLTemplate(string folder, string uxmlContent = "")
        {
            if (!Directory.Exists(UxmlSchemaGenerator.k_SchemaFolder))
                UxmlSchemaGenerator.UpdateSchemaFiles();

            var pathComponents = folder.Split(new[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
            var backDots = new List<string>();
            foreach (var s in pathComponents)
            {
                switch (s)
                {
                    case ".":
                        continue;
                    case ".." when backDots.Count > 0:
                        backDots.RemoveAt(backDots.Count - 1);
                        break;
                    default:
                        backDots.Add("..");
                        break;
                }
            }
            backDots.Add(UxmlSchemaGenerator.k_SchemaFolder);
            var schemaDirectory = string.Join("/", backDots.ToArray());

            var uxmlTemplate = String.Format(@"<?xml version=""1.0"" encoding=""utf-8""?>
<engine:{0}
    xmlns:xsi=""http://www.w3.org/2001/XMLSchema-instance""
    xmlns:engine=""UnityEngine.UIElements""
    xmlns:editor=""UnityEditor.UIElements""
    xsi:noNamespaceSchemaLocation=""{1}/UIElements.xsd""
>
    {2}
</engine:{0}>", UXMLImporterImpl.k_RootNode, schemaDirectory, uxmlContent);

            return uxmlTemplate;
        }
    }
}
