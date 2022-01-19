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

namespace Unifiedban.Next.Common
{
    public abstract class PluginBase
    {
        public string Name = "";
        public int Priority { get; } = 10;
        public string Group { get; } = "";
        public ResultValueAttribute.ResultType ResultType { get; }
        public ResultValueAttribute.ResultAction Action { get; }

        protected PluginBase(int priority)
        {
            Priority = priority;
            Group = "";
            ResultType = ResultValueAttribute.ResultType.Mandatory;
            Action = ResultValueAttribute.ResultAction.Delete;
        }

        protected PluginBase(int priority, string group = "")
        {
            Priority = priority;
            Group = group;
            ResultType = ResultValueAttribute.ResultType.Mandatory;
            Action = ResultValueAttribute.ResultAction.Delete;
        }

        protected PluginBase(
            int priority,
            string group = "",
            ResultValueAttribute.ResultType resultType = ResultValueAttribute.ResultType.Mandatory)
        {
            Priority = priority;
            Group = group;
            ResultType = resultType;
            Action = ResultValueAttribute.ResultAction.Delete;
        }

        protected PluginBase(
            int priority,
            string group = "",
            ResultValueAttribute.ResultType resultType = ResultValueAttribute.ResultType.Mandatory,
            ResultValueAttribute.ResultAction resultAction = ResultValueAttribute.ResultAction.Delete)
        {
            Priority = priority;
            Group = group;
            ResultType = resultType;
            Action = resultAction;
        }
    }
}