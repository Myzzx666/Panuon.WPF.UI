﻿using Panuon.WPF.UI;
using Panuon.WPF.UI.Configurations;
using System;
using System.Windows;

namespace Panuon.WPF.UI
{
    public class NoticeBoxSettings
    {
        #region Ctor
        static NoticeBoxSettings()
        {
            Setting = new NoticeBoxSetting();
        }
        #endregion

        #region Static Properties
        public static NoticeBoxSetting Setting { get; }
        #endregion

        #region Properties

        #region CreateOnNewThread
        public bool CreateOnNewThread
        {
            get
            {
                return Setting.CreateOnNewThread;
            }
            set
            {
                Setting.CreateOnNewThread = value;
            }
        }
        #endregion

        #region NoticeBoxItemStyle
        public Style NoticeBoxItemStyle
        {
            get
            {
                return Setting.NoticeBoxItemStyle;
            }
            set
            {
                Setting.NoticeBoxItemStyle = value;
            }
        }
        #endregion

        #region AnimationDuration
        public TimeSpan AnimationDuration
        {
            get
            {
                return Setting.AnimationDuration;
            }
            set
            {
                Setting.AnimationDuration = value;
            }
        }
        #endregion

        #region AnimationEase
        public AnimationEase AnimationEase
        {
            get
            {
                return Setting.AnimationEase;
            }
            set
            {
                Setting.AnimationEase = value;
            }
        }
        #endregion

        #endregion
    }
}
