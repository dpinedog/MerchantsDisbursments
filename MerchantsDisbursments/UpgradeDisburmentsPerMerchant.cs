using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MerchantsDisbursments
{
    public class UpgradeDisburmentsPerMerchant
    {
        private static bool threadWorking = false;


        public static void UpgradeDisburments() {
            try
            {
                if (!threadWorking)
                {
                    threadWorking = true;

                    //Read files and create estructures
                    System.Diagnostics.Debug.WriteLine("Reading files...");
                    //calculate Disbursements
                    System.Diagnostics.Debug.WriteLine("Calculating Disbursements...");
                    //Create/Upgrade file with upgraded data
                    System.Diagnostics.Debug.WriteLine("Consolidating Disbursements...");

                    threadWorking = false;
                }
            }catch(Exception e)
            {
                System.Diagnostics.Debug.WriteLine("Exception calculating disbursements: "+ e.Message);
                threadWorking = false;
            }
        }
    }
}
