namespace LeetCode.Com.Easy
{
    /// <summary>
    /// Design Parking System
    /// </summary>
    public class No1603
    {
        /*
            解题思路：私有变量记录big/medium/small车辆的数量，然后AddCar时比较是否有余量，并计数

            0 <= big, medium, small <= 1000
            carType is 1, 2, or 3
            At most 1000 calls will be made to addCar
         */

        private int big = 0;
        private int medium = 0;
        private int small = 0;

        public No1603(int big, int medium, int small)
        //public ParkingSystem(int big, int medium, int small)
        {
            this.big = big;
            this.medium = medium;
            this.small = small;
        }

        public bool AddCar(int carType)
        {
            switch (carType)
            {
                case 1:
                    if (this.big > 0)
                    {
                        this.big--;
                        return true;
                    }
                    break;
                case 2:
                    if (this.medium > 0)
                    {
                        this.medium--;
                        return true;
                    }
                    break;
                case 3:
                    if (this.small > 0)
                    {
                        this.small--;
                        return true;
                    }
                    break;
                default:
                    break;
            }

            return false;
        }

        /**
         * Your ParkingSystem object will be instantiated and called as such:
         * ParkingSystem obj = new ParkingSystem(big, medium, small);
         * bool param_1 = obj.AddCar(carType);
         */
    }
}
