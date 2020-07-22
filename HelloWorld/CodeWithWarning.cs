namespace HelloWorld
{
    public static
        
        class CodeWithWarning {

        public static int DoSomething1(int a, int b) {
            return a + b; }

        public   static    string    DoSomething2   (  string a  , string b   )
        {
            return 
                a 
                + "" 
                +    b;
        }

        public static int[] DoSomething3(int length)
        {
            var   array   =  new
                int
                [
                    length
                ];

            for
            (
                int i = 0 ;   i   <   length ; i ++
            )
            {
                array [i] = i ;
            }

            return   array;
        }

    }


}
