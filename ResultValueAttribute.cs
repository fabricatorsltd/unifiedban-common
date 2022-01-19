/* unified/ban - Management and protection systems

© fabricators SRL, https://fabricators.ltd , https://unifiedban.solutions

This program is free software: you can redistribute it and/or modify
it under the terms of the fabricator's FOSS License.

This program is distributed in the hope that it will be useful,
but WITHOUT ANY WARRANTY; without even the implied warranty of
MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
GNU Affero General Public License for more details.

You should have received a copy of the fabricator's FOSS License
along with this program.  If not, see <https://fabricators.ltd/FOSSLicense>. */

using System;

namespace Unifiedban.Next.Common
{
    [AttributeUsage(AttributeTargets.Class)]
    public sealed class ResultValueAttribute : Attribute
    {
        public enum ResultType
        {
            Mandatory = 0,
            Optional = 1
        }

        public enum ResultAction
        {
            Delete = 0,
            Warn = 1,
            Limit = 2,
            Kick = 3,
            Ban = 4
        }

        public ResultType Value { get; }
        public ResultAction Action { get; }

        public ResultValueAttribute(
            ResultType value,
            ResultAction action = ResultAction.Delete)
        {
            Value = value;
            Action = action;
        }
    }
}