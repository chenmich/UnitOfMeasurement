using System;

namespace CreateQuantityClass
{
    public class QT
    {
        public string qtCode;
        public string qtName;
        public Guid qtId;
        public QTExpression qtExp;
    }
    public class QTExpression
    {
        public string leftCode;
        public string rightCode;
        public string op;
    }

}
