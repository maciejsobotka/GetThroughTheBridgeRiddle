using System;

namespace GetThroughTheBridgeRiddle
{
    public static class Algorithm
    {
        #region Public static methods

        public static int GetAllThroughTheBridge(int[] sprinters)
        {
            var time = 0;
            int slowSprinters = sprinters.Length / 2;
            int slowSpriterCouples = slowSprinters / 2;
            int fastSprintersNeeded = slowSpriterCouples + 1;
            int afterSlowSprintersPassed = sprinters.Length - slowSpriterCouples * 2;

            if (sprinters.Length == 1)
            {
                return sprinters[0];
            }
            Array.Sort(sprinters);

            for (int i = fastSprintersNeeded; i > 1; --i)
            {
                //go left
                time += sprinters[i - 1];
                //go right
                time += sprinters[0];
            }
            for (var i = 0; i < slowSpriterCouples; ++i)
            {
                //slow guys left
                time += sprinters[sprinters.Length - (i * 2 + 1)];
                // fast sprinter right
                time += sprinters[1 + i];
            }
            for (int i = afterSlowSprintersPassed; i > 1; --i)
            {
                //go left
                time += sprinters[i - 1];
                if (i > 2)
                {
                    //go right
                    time += sprinters[0];
                }
            }
            return time;
        }

        #endregion
    }
}