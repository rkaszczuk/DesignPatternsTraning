using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace DesignPatternsSamples.ObjectPool
{
    public class IpAddressPool
    {
        private readonly int PoolLimit = 500000;
        private static List<string> IpAddressesAvailable = new List<string>();
        private static List<string> IpAddressesInUse = new List<string>();
        private static object lockGet = new object();
        private static object lockListAccess = new object();
        public string GetAddressFromPool()
        {
            lock (lockGet)
            {
                string resultIP = null;
                while (resultIP == null)
                {
                    lock (lockListAccess)
                    {
                        if (IpAddressesAvailable.Any())
                        {
                            resultIP = IpAddressesAvailable.First();
                            IpAddressesAvailable.Remove(resultIP);
                            IpAddressesInUse.Add(resultIP);
                        }
                        else
                        {
                            if ((IpAddressesAvailable.Count + IpAddressesInUse.Count) < PoolLimit)
                            {
                                resultIP = "asfasjklfjasjfsajkasfjkafjkajkajasffafasjkfasjklfasjlafsj" + (IpAddressesAvailable.Count + IpAddressesInUse.Count).ToString();
                                IpAddressesInUse.Add(resultIP);
                            }
                        }
                    }
                }
                return resultIP;
            }
        }
        public void ReturnIPToPool(string IP)
        {
            lock (lockListAccess)
            {
                IpAddressesInUse.Remove(IP);
                IpAddressesAvailable.Add(IP);
            }
        }
    }
}
