namespace LeetCode.Com.Easy
{
    /// <summary>
    /// [1108]  Defanging an IP Address
    /// </summary>
    public class No1108
    {
        public string DefangIPaddr(string address)
        {
            if (string.IsNullOrWhiteSpace(address)) return "";
            return address.Replace(".", "[.]");
        }
    }
}
