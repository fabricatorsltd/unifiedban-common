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