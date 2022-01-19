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
    public class Response
    {
        public int StatusCode { get; set; }
        public string StatusDescription { get; set; }
        public object Payload { get; set; }
    }

    public class Response<T>
    {
        public int StatusCode { get; set; }
        public string StatusDescription { get; set; }
        public T Payload { get; set; }
        public object PayloadRaw { get; set; }
    }
}