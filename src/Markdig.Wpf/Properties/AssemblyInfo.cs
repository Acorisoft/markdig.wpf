// Copyright (c) Nicolas Musset. All rights reserved.
// This file is licensed under the MIT license. 
// See the LICENSE.md file in the project root for more information.

using System.Windows;
using System.Windows.Markup;

[assembly: ThemeInfo(ResourceDictionaryLocation.SourceAssembly, ResourceDictionaryLocation.SourceAssembly)]
[assembly: XmlnsDefinition("https://github.com/Acorisoft/markdig.wpf", "Markdig.Wpf")]

namespace Markdig.Wpf
{
    public static partial class Markdown
    {
        /// <summary>
        /// Version of this library.
        /// </summary>
        public const string Version = "0.4.0";
    }
}