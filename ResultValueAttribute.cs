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