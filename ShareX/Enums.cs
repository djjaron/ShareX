﻿#region License Information (GPL v3)

/*
    ShareX - A program that allows you to take screenshots and share any file type
    Copyright (c) 2007-2016 ShareX Team

    This program is free software; you can redistribute it and/or
    modify it under the terms of the GNU General Public License
    as published by the Free Software Foundation; either version 2
    of the License, or (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program; if not, write to the Free Software
    Foundation, Inc., 51 Franklin Street, Fifth Floor, Boston, MA  02110-1301, USA.

    Optionally you can also view the license at <http://www.gnu.org/licenses/>.
*/

#endregion License Information (GPL v3)

using Newtonsoft.Json;
using System;
using System.ComponentModel;

namespace ShareX
{
    public enum ShareXBuild
    {
        Debug,
        Release,
        Steam,
        Unknown
    }

    public enum SupportedLanguage
    {
        Automatic, // Localized
        [Description("Nederlands (Dutch)")]
        Dutch,
        [Description("English")]
        English,
        [Description("Français (French)")]
        French,
        [Description("Deutsch (German)")]
        German,
        [Description("Magyar (Hungarian)")]
        Hungarian,
        [Description("한국어 (Korean)")]
        Korean,
        [Description("Português-Brasil (Portuguese-Brazil)")]
        PortugueseBrazil,
        [Description("Русский (Russian)")]
        Russian,
        [Description("简体中文 (Simplified Chinese)")]
        SimplifiedChinese,
        [Description("Español (Spanish)")]
        Spanish,
        [Description("Türkçe (Turkish)")]
        Turkish,
        [Description("Tiếng Việt (Vietnamese)")]
        Vietnamese
    }

    public enum TaskJob
    {
        Job,
        DataUpload,
        FileUpload,
        TextUpload,
        ShortenURL,
        ShareURL,
        DownloadUpload
    }

    public enum TaskStatus
    {
        InQueue,
        Preparing,
        Working,
        Stopping,
        Completed
    }

    [Flags]
    public enum AfterCaptureTasks // Localized
    {
        None = 0,
        ShowQuickTaskMenu = 1,
        ShowAfterCaptureWindow = 1 << 1,
        AddImageEffects = 1 << 2,
        AnnotateImage = 1 << 3,
        CopyImageToClipboard = 1 << 4,
        SendImageToPrinter = 1 << 5,
        SaveImageToFile = 1 << 6,
        SaveImageToFileWithDialog = 1 << 7,
        SaveThumbnailImageToFile = 1 << 8,
        PerformActions = 1 << 9,
        CopyFileToClipboard = 1 << 10,
        CopyFilePathToClipboard = 1 << 11,
        ShowInExplorer = 1 << 12,
        ShowBeforeUploadWindow = 1 << 13,
        UploadImageToHost = 1 << 14,
        DeleteFile = 1 << 15
    }

    [Flags]
    public enum AfterUploadTasks // Localized
    {
        None = 0,
        ShowAfterUploadWindow = 1,
        UseURLShortener = 1 << 1,
        ShareURL = 1 << 2,
        CopyURLToClipboard = 1 << 3,
        OpenURL = 1 << 4,
        ShowQRCode = 1 << 5
    }

    public enum CaptureType
    {
        Screen,
        Monitor,
        ActiveMonitor,
        Window,
        ActiveWindow,
        Rectangle,
        Polygon,
        Freehand,
        CustomRegion,
        LastRegion
    }

    public enum ScreenRecordStartMethod
    {
        Region,
        ActiveWindow,
        LastRegion
    }

    [JsonConverter(typeof(HotkeyTypeEnumConverter))]
    public enum HotkeyType // Localized + Category
    {
        None,
        // Upload
        FileUpload,
        FolderUpload,
        ClipboardUpload,
        ClipboardUploadWithContentViewer,
        UploadURL,
        DragDropUpload,
        StopUploads,
        // Screen capture
        PrintScreen,
        ActiveWindow,
        ActiveMonitor,
        RectangleRegion,
        RectangleAnnotate,
        RectangleLight,
        RectangleTransparent,
        PolygonRegion,
        FreeHandRegion,
        CustomRegion,
        LastRegion,
        ScrollingCapture,
        CaptureWebpage,
        AutoCapture,
        StartAutoCapture,
        // Screen record
        ScreenRecorder,
        ScreenRecorderActiveWindow,
        StartScreenRecorder,
        ScreenRecorderGIF,
        ScreenRecorderGIFActiveWindow,
        StartScreenRecorderGIF,
        // Tools
        ColorPicker,
        ScreenColorPicker,
        ImageEditor,
        ImageEffects,
        HashCheck,
        DNSChanger,
        QRCode,
        Ruler,
        Automate,
        IndexFolder,
        ImageCombiner,
        VideoThumbnailer,
        FTPClient,
        TweetMessage,
        MonitorTest,
        // Other
        DisableHotkeys,
        OpenScreenshotsFolder
    }

    public enum HotkeyStatus
    {
        Registered,
        Failed,
        NotConfigured
    }

    public enum PopUpNotificationType // Localized
    {
        None,
        BalloonTip,
        ToastNotification
    }

    [DefaultValue(OpenUrl)]
    public enum ToastClickAction
    {
        [Description("Annotate image")]
        AnnotateImage,
        [Description("Copy image to clipboard")]
        CopyImageToClipboard,
        [Description("Copy URL")]
        CopyUrl,
        [Description("Open file")]
        OpenFile,
        [Description("Open folder")]
        OpenFolder,
        [Description("Open URL")]
        OpenUrl,
        [Description("Upload")]
        Upload
    }

    public enum FileExistAction // Localized
    {
        Ask,
        Overwrite,
        UniqueName,
        Cancel
    }

    public enum ImagePreviewVisibility
    {
        Show, Hide, Automatic
    }

    public enum ScreenRecordState
    {
        Waiting, BeforeStart, AfterStart, AfterRecordingStart, AfterStop
    }
}