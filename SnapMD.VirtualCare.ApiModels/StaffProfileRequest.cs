﻿#region Copyright
//    Copyright 2016 SnapMD, Inc.
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
//        http://www.apache.org/licenses/LICENSE-2.0
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.
#endregion

namespace SnapMD.VirtualCare.ApiModels
{
    /// <summary>
    /// Staff Profile Request.
    /// </summary>
    public class StaffProfileRequest : BaseProfile
    {
        /// <summary>
        /// Admin User ID.
        /// </summary>
        public int AdminUserID { get; set; }

        /// <summary>
        /// Staff User ID.
        /// </summary>
        public int StaffUserID { get; set; }

        /// <summary>
        /// Optional doctor setting.
        /// Doctor setting: RXNT user name,
        /// </summary>
        public string rxntUserName { get; set; }

        /// <summary>
        /// Optional doctor setting.
        /// Doctor setting: RXNT user password,
        /// </summary>
        public string rxntUserPassword { get; set; }
    }
}