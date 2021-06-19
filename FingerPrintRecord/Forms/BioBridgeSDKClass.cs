#region Assembly BioBridgeSDKDLLv3, Version=3.0.0.3, Culture=neutral, PublicKeyToken=null
// G:\FingerTec BioBridge SDK\Sample Source Code\DLL Sample Source Code - C#\WinBioBridgeNewSDK\bin\Debug\BioBridgeSDKDLLv3.dll
#endregion


namespace BioBridgeSDKDLL
{
    public sealed class BioBridgeSDKClass : IBioBridgeSDKEvents
    {
        public BioBridgeSDKClass();

        public string VC { get; set; }
        public int SSR_UserFile { get; set; }
        public string SN { get; set; }
        public short Reserved { get; set; }
        public string MAC { get; set; }
        public short FaceBlockSize { get; set; }
        public int DN { get; set; }
        public string DC { get; set; }
        public int CardNo { get; set; }
        public int Finger10 { get; set; }

        public event IBioBridgeSDKEvents_OnFingerEventHandler OnFinger;
        public event IBioBridgeSDKEvents_OnDisConnectedEventHandler OnDisConnected;
        public event IBioBridgeSDKEvents_OnAttTransactionExEventHandler OnAttTransactionEx;
        public event IBioBridgeSDKEvents_OnConnectedEventHandler OnConnected;
        public event IBioBridgeSDKEvents_OnDoorEventHandler OnDoor;
        public event IBioBridgeSDKEvents_OnAlarmEventHandler OnAlarm;

        public short BackupData(string dataFile);
        public short BatchUpdate();
        public short BeginBatchUpdate();
        public short ClearAdministrator();
        public short ClearAllData();
        public short ClearErrorCard();
        public short ClearPhotoByTime(int iFlag, string sTime, string eTime);
        public short ClearSMS();
        public short ClearUserSMS();
        public short Connect_COMM(string deviceModel, int deviceNo, int commPort, int baudRate, int commKey);
        public short Connect_TCPIP(string deviceModel, int deviceNo, string ipAddress, int portNo, int commKey);
        public short Connect_USB(string deviceModel, int deviceNo, int commKey);
        public int ConvertFPToFT(string enrollData1, ref string enrollData2, ref int enrollSize);
        public int ConvertFPToOFIS(string enrollData1, ref string enrollData2, ref int enrollSize);
        public short DecryptLog(string filename, ref string decrypted);
        public short DeleteGeneralLog();
        public short DeletePicture(string fileName);
        public short DeleteSMS(int id);
        public short DeleteUserData(int enrollNo);
        public short DeleteUserFace(string enrollNo);
        public short DeleteUserPhoto(string fileName);
        public short DeleteUserSMS(int enrollNo, int id);
        public short DeleteUserTemplate(int enrollNo, int enrollId);
        public short DisableDevice();
        public int DisableDeviceWithTimeout(int timeoutSecond);
        public short Disconnect();
        public short DownloadPicture(string fileName, string filepath);
        public short DownloadUserPhoto(string fileName, string filepath);
        public short EnableDevice();
        public short GetAdminCardNumber(ref int adminCard);
        public short GetAllUserInfo(ref int enrollNo, ref string name, ref string password, ref int privilege, ref bool enabled);
        public short GetAntipassback(ref string value);
        public short GetCardNo(ref string cardNo);
        public short GetDeviceID(ref string deviceID);
        public short GetDeviceInfo(int infoId, ref int infoValue);
        public short GetDeviceStatus(int statusId, ref int statusValue);
        public short GetDeviceTime(ref int year, ref int month, ref int day, ref int hour, ref int minute, ref int second);
        public short GetEncodingCode(ref string sCode);
        public short GetErrorCardData(ref int cardNo, ref string timeStamp);
        public short GetEveryWeekTimeZone(int iDayOfWeek, ref string sTimeZone, ref string sVerifyStyle);
        public short GetFaceFileData(ref int enrollNo, ref string faceData);
        public short GetFailPhotos(string filepath, ref string filenames);
        public short GetFinger10FileData(ref int enrollNo, ref int enrollId, ref string enrollData);
        public short GetFirmwareVersion(ref string firmwareVersion);
        public short GetGateway(ref string gateway);
        public short GetGeneralLog(ref int enrollNo, ref int year, ref int month, ref int day, ref int hour, ref int minute, ref int second, ref int verifyMode, ref int inOutMode, ref int workCode);
        public short GetGroupTimezone(int groupId, ref string timezone);
        public short GetGroupTimezoneVerify(int groupId, ref string timezone, ref string verifyStyle);
        public short GetHolidayParam(int iHolidayid, ref int iTZid, ref int iStartMonth, ref int iStartDay, ref int iEndMonth, ref int iEndDay);
        public short GetPhotoByName(string photoName, out byte[] PhotoData, out int PhotoLength);
        public short GetPhotoNamesByTime(int iFlag, string sTime, string eTime, out string AllPhotoName);
        public short GetPlatform(ref string platform);
        public int GetPowerOff(ref int hour, ref int minute);
        public int GetPowerOn(ref int hour, ref int minute);
        public short GetRTLog();
        public short GetSDKVersion(ref string sDKVersion, int @base);
        public int GetSleep(ref int hour, ref int minute);
        public short GetSMS(int id, ref int tag, ref int validMinutes, ref string startTime, ref string content);
        public short GetSubnetMask(ref string subnetMask);
        public short GetSuccessPhotos(string filepath, ref string filenames);
        public short GetSysOption(string option, ref string value);
        public short GetTCMSv2(ref string enrollNo, ref string empName, ref string empNo, ref string dept, ref string section, ref string grpCode, ref string date, ref string dayType, ref string scheCode, ref string shiftNo, ref string @in, ref string @break, ref string resume, ref string @out, ref string ot, ref string done, ref double work, ref double overtime, ref double diffOt, ref double @short, ref string leaveType, ref string remark);
        public short GetTemplateFileData(ref int enrollNo, ref int enrollId, ref string sTemplate);
        public short GetTimezoneInfo(int timezoneId, ref string timezoneInfo);
        public short GetUnlockCombo(int combNo, ref string unlockGroup);
        public short GetUnlockGroup(ref string unlockGroup);
        public short GetUserFace(string enrollNo, ref string faceData);
        public short GetUserFileData(ref int enrollNo, ref string name, ref string password, ref int privilege, ref int tZgrp, ref string tZstr);
        public short GetUserFileDataCard(ref int enrollNo, ref string name, ref string password, ref int privilege, ref int tZgrp, ref string tZstr, ref string sCard);
        public short GetUserGroup(int enrollNo, ref int userGroup);
        public short GetUserInfo(int enrollNo, ref string name, ref string password, ref int privilege, ref bool enabled);
        public short GetUserTemplate(int enrollNo, int enrollId, ref string enrollData);
        public short GetUserTimezone(int enrollNo, ref string timezone);
        public short GetUserVerType(int enrollNo, ref int verType);
        public short IsTFT();
        public short PutFaceFileData(int enrollNo, string faceData, int faceSize);
        public short PutFinger10FileData(int enrollNo, int enrollId, string enrollData, int templateSize);
        public short PutTemplateFileData(int enrollNo, int enrollId, string enrollData, int templateSize);
        public short PutUserFileData(int enrollNo, string name, string password, int privilege, int tZgrp, string tZstr, int userSize);
        public short PutUserFileDataCard(int enrollNo, string name, string password, int privilege, int tZgrp, string tZstr, string cardno, int userSize);
        public short ReadAllUserInfo(ref int userSize);
        public short ReadErrorCard();
        public short ReadFaceFile(string fileName);
        public short ReadFinger10File(string fileName);
        public short ReadGeneralLog(ref int logSize);
        public short ReadRTLog();
        public short ReadTCMSv2(string dirPath, string dateFrom, string dateTo, ref int recordSize);
        public short ReadTemplateFile(string fileName);
        public short ReadUserFile(string fileName);
        public short Refresh();
        public short RestartDevice();
        public short RestoreData(string dataFile);
        public short SetAdminCardNumber(int adminCard);
        public short SetAntipassback(string value);
        public int SetCardNo(string cardNo);
        public short SetDeviceCommKey(int commKey);
        public short SetDeviceInfo(int infoId, int infoValue);
        public short SetDeviceTime(int year, int month, int day, int hour, int minute, int second);
        public short SetDeviceTimeLocal();
        public short SetEveryWeekTimeZone(int iDayOfWeek, string sTimeZone, string sVerifyStyle);
        public short SetGateway(string gateway);
        public short SetGroupTimezone(int groupId, string timezone);
        public short SetGroupTimezoneVerify(int groupId, string timezone, string verifyStyle);
        public short SetHolidayParam(int iHolidayid, int iTimezondId, int iStartMonth, int iStartDay, int iEndMonth, int iEndDay);
        public int SetLastCount(int count);
        public int SetPowerOff(int hour, int minute);
        public int SetPowerOn(int hour, int minute);
        public int SetSleep(int hour, int minute);
        public short SetSMS(int id, int tag, int validMinutes, string startTime, string content);
        public short SetSubnetMask(string subnetMask);
        public short SetTimezoneInfo(int timezoneId, string timezoneInfo);
        public short SetUnlockCombo(int combNo, string unlockGroup);
        public short SetUnlockGroup(string unlockGroup);
        public short SetUserFace(string enrollNo, string faceData);
        public short SetUserFace_Fmm(string enrollNo, string faceData);
        public short SetUserGroup(int enrollNo, int userGroup);
        public short SetUserInfo(int enrollNo, string name, string password, int privilege, bool enabled);
        public short SetUserSMS(int enrollNo, int id);
        public short SetUserTemplate(int enrollNo, int enrollId, string enrollData);
        public short SetUserTimezone(int enrollNo, string timezone);
        public short SetUserVerType(int enrollNo, int verType);
        public short SSR_ClearWorkCode();
        public short SSR_DeleteUserData(string enrollNo);
        public short SSR_DeleteUserSMS(string enrollNo, int id);
        public short SSR_DeleteUserTemplate(string enrollNo, int enrollId);
        public short SSR_DeleteWorkCode(int workId);
        public short SSR_GetAllUserInfo(ref string enrollNo, ref string name, ref string password, ref int privilege, ref bool enabled);
        public short SSR_GetGeneralLog(ref string enrollNo, ref int year, ref int month, ref int day, ref int hour, ref int minute, ref int second, ref int verifyMode, ref int inOutMode, ref int workCode);
        public short SSR_GetGroupTimeZone(int groupId, ref int tZ1, ref int tZ2, ref int tZ3, ref int validHoliday, ref int verType);
        public short SSR_GetHoliday(int holidayId, ref int beginMonth, ref int beginDay, ref int endMonth, ref int endDay, ref int tZgrp);
        public short SSR_GetUnlockGroup(int combNo, ref int group1, ref int group2, ref int group3, ref int group4, ref int group5);
        public short SSR_GetUserFileDataCard(ref int enrollNo, ref string name, ref string password, ref int privilege, ref int tZgrp, ref string tZstr, ref string cardNo);
        public short SSR_GetUserInfo(string enrollNo, ref string name, ref string password, ref int privilege, ref bool enabled);
        public short SSR_GetUserTemplate(string enrollNo, int enrollId, ref string enrollData);
        public short SSR_GetWorkCode(int workId, ref string workDesc);
        public short SSR_PutUserFileDataCard(int enrollNo, string name, string password, int privilege, int tZgrp, string tZstr, string cardNo, int userSize);
        public short SSR_ReadUserFile(string fileName);
        public short SSR_SetGroupTZ(int groupNo, int tZ1, int tZ2, int tZ3, int validHoliday, int verType);
        public short SSR_SetHoliday(int holidayId, int beginMonth, int beginDay, int endMonth, int endDay, int tZgrp);
        public short SSR_SetUnLockGroup(int combNo, int group1, int group2, int group3, int group4, int group5);
        public short SSR_SetUserInfo(string enrollNo, string name, string password, int privilege, bool enabled);
        public short SSR_SetUserSMS(string enrollNo, int id);
        public short SSR_SetUserTemplate(string enrollNo, int enrollId, string enrollData);
        public short SSR_SetWorkCode(int workId, string workDesc);
        public short SSR_WriteUserFile(string fileName);
        public short TurnOffAlarm();
        public short UnlockDoor(int delay);
        public short UploadPicture(string fileName);
        public short UploadTheme(string fileName);
        public short UploadUserPhoto(string fileName);
        public short WriteFaceFile(string fileName);
        public short WriteFinger10File(string fileName);
        public short WriteTemplateFile(string fileName);
        public short WriteUserFile(string fileName);
    }
}