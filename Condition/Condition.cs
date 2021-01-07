using System;

namespace Condition
{
    public static class Condition
    {
        /// <summary>
        /// Implement code according to description of  task 1
        /// </summary>        
        public static int Task1(int n)
        {
             int res;
                        
            if (n <= 0)
            {
                 res = Math.Abs(n);         
            }
            else res = n * n;
            return res;
            throw new NotImplementedException();
        }

        /// <summary>
        /// Implement code according to description of  task 2
        /// </summary>  
        public static int Task2(int n)
        {
           string count = n.ToString();
           char f = count[0];
            char s = count[1];
            char t = count[2];
            string result;
            if (f >= s && f >= t)
            {
            if (s >= t)
            {
                  result = f.ToString() + s.ToString() + t.ToString();
              
            }
            else  result = f.ToString() + t.ToString() + s.ToString();
                
            }
            else if (s >= f && s >= t)
            {
                if (f >= t)
                            result = s.ToString() + f.ToString() + t.ToString();
                   
                else  result = s.ToString() + t.ToString() + f.ToString();
                  
            }

            else
                if (f >= s)
                      result = t.ToString() + f.ToString() + s.ToString();
                
            else
                    result = f.ToString() + s.ToString() + t.ToString();
               
			int resultt = int.Parse(result);
             return resultt;
              }
    }
}
