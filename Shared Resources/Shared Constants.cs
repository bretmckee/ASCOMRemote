﻿using Microsoft.Win32;

namespace ASCOM.Remote
{
    public static class SharedConstants
    {
        // Alpaca and ASCOM error number constants
        public const int ASCOM_ERROR_NUMBER_OFFSET = unchecked((int)0x80040000); // Offset value that relates the ASCOM Alpaca reserved error number range to the ASCOM COM HResult error number range
        public const int ASCOM_ERROR_NUMBER_BASE = unchecked((int)0x80040400); // Lowest ASCOM error number
        public const int ASCOM_ERROR_NUMBER_MAX = unchecked((int)0x80040FFF); // Highest ASCOM error number
        public const int ALPACA_ERROR_CODE_BASE = 0x400; // Start of the Alpaca error code range 0x400 to 0xFFF
        public const int ALPACA_ERROR_CODE_MAX = 0xFFF; // End of Alpaca error code range 0x400 to 0xFFF

        // HTTP Parameter names shared by driver and remote server
        public const string RA_PARAMETER_NAME = "RightAscension";
        public const string DEC_PARAMETER_NAME = "Declination";
        public const string ALT_PARAMETER_NAME = "Altitude";
        public const string AZ_PARAMETER_NAME = "Azimuth";
        public const string AXIS_PARAMETER_NAME = "Axis";
        public const string RATE_PARAMETER_NAME = "Rate";
        public const string DIRECTION_PARAMETER_NAME = "Direction";
        public const string DURATION_PARAMETER_NAME = "Duration";
        public const string CLIENTID_PARAMETER_NAME = "ClientID";
        public const string CLIENTTRANSACTION_PARAMETER_NAME = "ClientTransactionID";
        public const string COMMAND_PARAMETER_NAME = "Command";
        public const string RAW_PARAMETER_NAME = "Raw";
        public const string LIGHT_PARAMETER_NAME = "Light";
        public const string ACTION_COMMAND_PARAMETER_NAME = "Action";
        public const string ACTION_PARAMETERS_PARAMETER_NAME = "Parameters";
        public const string ID_PARAMETER_NAME = "ID";
        public const string STATE_PARAMETER_NAME = "State";
        public const string NAME_PARAMETER_NAME = "Name";
        public const string VALUE_PARAMETER_NAME = "Value";
        public const string POSITION_PARAMETER_NAME = "Position";
        public const string SIDEOFPIER_PARAMETER_NAME = "SideOfPier";
        public const string UTCDATE_PARAMETER_NAME = "UTCDate";
        public const string SENSORNAME_PARAMETER_NAME = "SensorName";

        public const string ISO8601_DATE_FORMAT_STRING = "yyyy-MM-ddTHH:mm:ss.fffffff";

        // Remote server setup form constants
        public const string LOCALHOST_NAME = "localhost";
        public const string LOCALHOST_ADDRESS = "127.0.0.1"; // Get the localhost loop back address
        public const string STRONG_WILDCARD_NAME = "+"; // Symbol for strong IP address wild card
        public const string WEAK_WILDCARD_NAME = "*"; // Symbol for weak IP address wild card

        // Constants shared by Remote Client Drivers and the ASCOM REST Server
        public const string API_URL_BASE = "/api/"; // This constant must always be lower case to make the logic tests work properly 
        public const string API_VERSION_V1 = "v1"; // This constant must always be lower case to make the logic tests work properly
        public const string MANAGEMENT_URL_BASE = "/server/"; // This constant must always be lower case to make the logic tests work properly 

        // Remote server management API interface constants
        public const string MANGEMENT_PROFILE = "profile";
        public const string MANGEMENT_CONFIGURATION = "configuration";
        // public const string MANGEMENT_API_ENABLED = "enabled"; // Commented out because this command can't be used if the management interface is disabled!
        public const string MANGEMENT_CONCURRENT_CALLS = "concurrency";
        public const string MANGEMENT_RESTART = "restart";

        // Client driver profile persistence constants
        public const string TRACE_LEVEL_PROFILENAME = "Trace Level"; public const string CLIENT_TRACE_LEVEL_DEFAULT = "True";
        public const string DEBUG_TRACE_PROFILENAME = "Include Debug Trace"; public const string DEBUG_TRACE_DEFAULT = "False";
        public const string IPADDRESS_PROFILENAME = "IP Address"; public const string IPADDRESS_DEFAULT = SharedConstants.LOCALHOST_ADDRESS;
        public const string PORTNUMBER_PROFILENAME = "Port Number"; public const string PORTNUMBER_DEFAULT = "11111";
        public const string REMOTE_DEVICE_NUMBER_PROFILENAME = "Remote Device Number"; public const string REMOTE_DEVICE_NUMBER_DEFAULT = "0";
        public const string SERVICE_TYPE_PROFILENAME = "Service Type"; public const string SERVICE_TYPE_DEFAULT = "http";
        public const string ESTABLISH_CONNECTION_TIMEOUT_PROFILENAME = "Establish Connection Timeout"; public const string ESTABLISH_CONNECTION_TIMEOUT_DEFAULT = "10";
        public const string STANDARD_SERVER_RESPONSE_TIMEOUT_PROFILENAME = "Standard Server Response Timeout"; public const string STANDARD_SERVER_RESPONSE_TIMEOUT_DEFAULT = "10";
        public const string LONG_SERVER_RESPONSE_TIMEOUT_PROFILENAME = "Long Server Response Timeout"; public const string LONG_SERVER_RESPONSE_TIMEOUT_DEFAULT = "120";
        public const string USERNAME_PROFILENAME = "User Name"; public const string USERNAME_DEFAULT = "";
        public const string PASSWORD_PROFILENAME = "Password"; public const string PASSWORD_DEFAULT = "";
        public const string MANAGE_CONNECT_LOCALLY_PROFILENAME = "Manage Connect Locally"; public const string MANAGE_CONNECT_LOCALLY_DEFAULT = "False";

        // Driver naming constants
        public const string DRIVER_DISPLAY_NAME = "ASCOM Remote Client";
        public const string DRIVER_PROGID_BASE = "ASCOM.Remote";
        public const string NOT_CONNECTED_MESSAGE = "is not connected."; // This is appended to the driver display name + driver number and displayed when the driver is not connected
        public const string TRACELOGGER_NAME_FORMAT_STRING = "Remote{0}.{1}";

        // Enum to describe Camera.ImageArray and ImageArrayVCariant array types
        public enum ImageArrayElementTypes
        {
            Unknown = 0,
            Short = 1,
            Int = 2,
            Double = 3
        }

        // Registry key where the Web Server configuration will be stored
        public const RegistryHive ASCOM_REMOTE_CONFIGURATION_HIVE = RegistryHive.CurrentUser;
        public const string ASCOM_REMOTE_CONFIGURATION_KEY = @"Software\ASCOM Remote";

        public const string REQUEST_RECEIVED_STRING = "RequestReceived";

        public const string DEVICE_NOT_CONFIGURED = "None"; // ProgID value indicating no device configured

    }
}
