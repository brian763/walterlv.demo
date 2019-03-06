﻿using System.Collections.Generic;
using Walterlv.Framework;

namespace Walterlv
{
    public class OptionsParser : ICommandLineOptionParser<Options>
    {
        private bool _isFromCloud;
        private string _filePath;
        private string _startupMode;
        private bool _isSilence;
        private bool _isIwb;
        private string _placement;
        private string _startupSession;

        public void SetValue(int index, string value)
        {
            switch (index)
            {
                case 0:
                    _filePath = value;
                    break;
            }
        }

        public void SetValue(char shortName, bool value)
        {
            switch (shortName)
            {
                case 's':
                    _isSilence = value;
                    break;
            }
        }

        public void SetValue(char shortName, string value)
        {
            switch (shortName)
            {
                case 'f':
                    _filePath = value;
                    break;
                case 'm':
                    _startupMode = value;
                    break;
            }
        }

        public void SetValue(char shortName, IEnumerable<string> values)
        {
        }

        public void SetValue(string longName, bool value)
        {
            switch (longName)
            {
                case "cloud":
                    _isFromCloud = value;
                    break;
                case "silence":
                    _isSilence = value;
                    break;
                case "iwb":
                    _isIwb = value;
                    break;
            }
        }

        public void SetValue(string longName, string value)
        {
            switch (longName)
            {
                case "file":
                    _filePath = value;
                    break;
                case "mode":
                    _startupMode = value;
                    break;
                case "placement":
                    _placement = value;
                    break;
                case "StartupSession":
                    _startupSession = value;
                    break;
            }
        }

        public void SetValue(string longName, IEnumerable<string> values)
        {
        }

        public Options Commit()
        {
            return new Options(_filePath, _isFromCloud, _startupMode, _isSilence, _isIwb, _placement, _startupSession);
        }
    }
}
