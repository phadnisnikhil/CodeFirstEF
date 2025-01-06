namespace CodeFirstEF
{
    public class Class
    {
        public readonly int varreadOnly;

        int num = 10;
        public Class()
        {
            varreadOnly = num;
         }
        public void Method()
        {
            var tim = 90;
            method("Nikhil", tim);
        }
        public void method(dynamic dynVar, dynamic timeTok)
        {
            //  varreadOnly = 20;
        }
    }
}
