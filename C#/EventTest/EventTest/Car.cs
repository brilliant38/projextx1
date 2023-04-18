using System;

namespace EventAndDelegateDemo
{   
    // 이벤트 게시자(publisher)
    class Car
    {
        private int _fuelGauge;

        public Car()
        {
            _fuelGauge = 25;
        
        }

        private int FuelGauge
        {
            get { return _fuelGauge; }
            set 
            { 
                _fuelGauge = value; 
            }
        }

        public void Go()
        {
            Console.WriteLine("운전");
            _fuelGauge -= 5; //-5%
        }

        //public delegate void FuelEmptyNotification();
        //public event FuelEmptyNotification FuelEmptyReached;

        public event Action FuelEmptyReached; //Action 대리자로도 가능.

        public void OnFuelEmptyReached()
        {
            Console.WriteLine($"연료 상태: {_fuelGauge}");
            if (_fuelGauge < 20) //연료가 20 미만이면
            {
                if (FuelEmptyReached != null)
                {
                    //FuelEmptyReached();
                    FuelEmptyReached.Invoke();
                } 
            }
        }

    }
}
