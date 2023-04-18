namespace MethodsOverride
{   
    class Parent //부모
    {
        protected void Say() => System.Console.WriteLine("부모_안녕하세요.");
        protected void Run() => System.Console.WriteLine("부모_달리다.");
        public virtual void Walk() => System.Console.WriteLine("부모_걷다.");
        public virtual void Work() => System.Console.WriteLine("부모_프로그래머.");
    }

    

    class Child : Parent // 자식
    {
        public void Say() => System.Console.WriteLine("자식 안녕하세요."); //메소드 오버라이딩
        public new void Run() => System.Console.WriteLine("자식_달리다.");
        //public new void Work() => System.Console.WriteLine("부모_프로게이머.");
        public override void Walk() => base.Walk();
        
        public override void Work()
        {
            System.Console.WriteLine("자식_프로게이머");
        }
    }

    class MethodsOverride
    {
        static void Main()
        {
            Child child = new Child();
            child.Say(); //자식이 예의가 없는 경우 x->x
            child.Run(); //자식이 예의가 있는 경우 x->new
            child.Walk();//부모도 관대하고 자식도 예의가 있는 경우 : virtual => override
            child.Work();//부모도 관대하고 자식도 예의가 있는 경우 : virtual => override
        }
    }
}
