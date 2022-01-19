/* unified/ban - Management and protection systems

© fabricators SRL, https://fabricators.ltd , https://unifiedban.solutions

This program is free software: you can redistribute it and/or modify
it under the terms of the GNU Affero General Public License with our addition
to Section 7 as published in unified/ban's the GitHub repository.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU Affero General Public License for more details.

You should have received a copy of the GNU Affero General Public License and the
additional terms along with this program. 
If not, see <https://docs.fabricators.ltd/docs/licenses/unifiedban>.

For more information, see Licensing FAQ: 

https://docs.fabricators.ltd/docs/licenses/faq */

using System;

namespace Unifiedban.Next.Common
{
    [Serializable]
    public struct Enums
    {
        public enum States
        {
            Disabled = -1,
            Stopped = 0,
            Startup = 1,
            Operational = 2,
            Overloaded = 3,
            Suspended = 4,
            Error = 5
        }
        
        public enum UserStates
        {
            Deleted = -1,
            Disabled = 0,
            Active = 1,
            Suspended = 2,
            Banned = 3,
            Merged = 4
        }
        
        public enum ChatStates
        {
            Disabled = 0,
            Active = 1,
            Suspended = 2
        }
        
        public enum StaffTypes
        {
            None = 0,
            Service = 1, // unifiedban
            Platform = 2, // telegram/discord/...
            Team = 3 // media agency / groups of groups
        }
        
        public enum UserLevels
        {
            User = 0,
            Subscriber = 1,
            Mod = 2,
            SuperMod = 3,
            Admin = 4,
            Owner = 100
        }
        
        public enum Platforms
        {
            Telegram = 0,
            Twitch = 1,
            Discord = 2
        }

        [Flags]
        public enum EnabledCommandsTypes
        {
            None = 0,
            All = 1,
            CoreOnly = 2,
            CustomOnly = 3
        }

        public enum TelegramPermissions
        {
            CanManageChat = 0,
            CanPostMessages = 1,
            CanEditMessages = 2,
            CanDeleteMessages = 3,
            CanManageVoiceChats = 4,
            CanRestrictMembers = 5,
            CanPromoteMembers = 6,
            CanChangeInfo = 7,
            CanInviteUsers = 8,
            CanPinMessages = 9
        }

        public enum QueueMessageCategories
        {
            Base = 0,
            Media = 1,
            File = 2,
            MemberJoin = 3,
            MemberLeave = 4
        }
    }
}