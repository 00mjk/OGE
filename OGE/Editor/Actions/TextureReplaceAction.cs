﻿using System;
using System.Xml.Linq;
using OGE.Editor.Interfaces;
using OGE.ViewModels.FileExplorer;

namespace OGE.Editor.Actions
{
    /// <summary>
    /// Action used to track texture replacements.
    /// This involves replacing a sub-texture of a peg/vbm file
    /// with another texture.
    /// </summary>
    public class TextureReplaceAction : ITrackedAction
    {
        public string PegName { get; private set; }
        public string SubTextureName { get; private set; }
        public bool TrackedByAsm { get; private set; } = false;
        public string? AsmName { get; private set; } = null;

        public TextureReplaceAction(FileExplorerItemViewModel target, string subTextureName, string replacementFilePath)
        {

        }

        void ITrackedAction.Undo()
        {
            throw new NotImplementedException();
        }

        void ITrackedAction.Redo()
        {
            throw new NotImplementedException();
        }

        void ITrackedAction.WriteToProjectFile(XElement changeNode)
        {
            throw new NotImplementedException();
        }

        void ITrackedAction.ReadFromProjectFile(XElement changeNode)
        {
            throw new NotImplementedException();
        }
    }
}
