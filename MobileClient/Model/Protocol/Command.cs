﻿using System;
using System.Collections.Generic;

namespace MobileClient
{
    public class Command
    {
        public Command(Commands command, string data)
        {
            CurrentCommand = Enum.GetName(typeof(Commands), command);
            Data = data;
            ValuesList = new List<List<object>>();
            ColumnsList = new List<string>();
            TypesList = new List<string>();
        }

        public string CurrentCommand { get; set; }
        public string Data { get; set; }
        public string FilePath { get; set; }
        public List<string> ColumnsList { get; set; }
        public List<string> TypesList { get; set; }
        public List<List<object>> ValuesList { get; set; }
        public byte[] File { get; set; }

        public enum Commands
        {
            SendFile,
            ReadFile,
            SendPhoto,
            ReadPhoto,
            SendPhotoLink,
            ReadPhotoLink,
            FullData,
            PreviewData,
            Login,
            AddRecord,
            UpdateRecord,
            DeleteRecord,
            Exit,
            Confirm,
            Reject
        }
    }
}
