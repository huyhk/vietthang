using System;
using System.Collections.Generic;
using System.Text;
using VNS.Common;
using System.Data;

namespace VNS.ERP.Data
{
    public class GTGT:ObjectBase
    {
        public GTGT()
        {
        }
        public GTGT(IDataReader Reader)
        {
            this.FromDataReader(Reader);
            
        }
       
        public  void CopyFrom(object obj)
        {
            gt10 = (obj as GTGT).gt10;
            gt11 = (obj as GTGT).gt11;
            gt14 = (obj as GTGT).gt14;
            gt15 = (obj as GTGT).gt15;
            gt16 = (obj as GTGT).gt16;
            gt17 = (obj as GTGT).gt17;
            gt26 = (obj as GTGT).gt26;
            gt29 = (obj as GTGT).gt29;
            gt30 = (obj as GTGT).gt30;
            gt31 = (obj as GTGT).gt31;
            gt32 = (obj as GTGT).gt32;
            gt33 = (obj as GTGT).gt33;

            gt18 = (obj as GTGT).gt18;
            gt19 = (obj as GTGT).gt19;
            gt20 = (obj as GTGT).gt20;
            gt21 = (obj as GTGT).gt21;
            gt23 = (obj as GTGT).gt23;
            gt34 = (obj as GTGT).gt34;
            gt35 = (obj as GTGT).gt35;
            gt36 = (obj as GTGT).gt36;
            gt37 = (obj as GTGT).gt37;
            gt42 = (obj as GTGT).gt42;
        }
        public override void FromDataReader(IDataReader reader)
        {
            base.FromDataReader(reader);
        }

        private string periodCode=string.Empty;
        public string PeriodCode
        {
            get { return periodCode; }
            set
            {
                periodCode = value;
            }
        }

        private bool gt10 ;
        public bool GT10
        {
            get { return gt10; }
            set { gt10 = value;
            //if (gt10 == true)
            //{
            //    gt14 = 0;
            //    gt15 = 0;
            //    gt16 = 0;
            //    gt17 = 0;
            //    gt26 = 0;
            //    gt29 = 0;
            //    gt30 = 0;
            //    gt31 = 0;
            //    gt32 = 0;
            //    gt33 = 0;
            //}
            }
        }
        private decimal gt11;
        public decimal GT11
        {
            get { return gt11; }
            set { gt11 = value;
            }
        }

        public decimal GT12
        {
            get { return gt14 + gt16; }
         }

        public decimal GT13
        {
            get { return gt15 + gt17; }
        }
        
        private decimal gt14;
        public decimal GT14
        {
            get { return gt14; }
            set { gt14 = value;
            }
        }
        private decimal gt15;
        public decimal GT15
        {
            get { return gt15; }
            set { gt15 = value;
            }
        }
        private decimal gt16;
        public decimal GT16
        {
            get { return gt16; }
            set { gt16 = value;
            }
        }

        private decimal gt17;
        public decimal GT17
        {
            get { return gt17; }
            set { gt17 = value;
            }
        }
        private decimal gt18;
        public decimal GT18
        {
            get { return gt18; }
            set { gt18 = value; }
        }
        private decimal gt19;
        public decimal GT19
        {
            get { return gt19; }
            set { gt19 = value;

            }
        }
        private decimal gt20;
        public decimal GT20
        {
            get { return gt20; }
            set { gt20 = value; }
        }
        private decimal gt21;
        public decimal GT21
        {
            get { return gt21; }
            set { gt21 = value;

            }
        }

        public decimal GT22
        {
            get { return GT13 + gt19 - gt21; }

        }
        private decimal gt23;
        public decimal GT23
        {
            get { return gt23; }
            set { gt23= value;
             }
        }
        public decimal GT24
        {
            get { return gt26 + GT27; }
         
        }

        public decimal GT25
        {
            get { return GT28; }
        }

        private decimal gt26;
        public decimal GT26
        {
            get { return gt26; }
            set { gt26 = value;}
        }

        public decimal GT27
        {
            get { return gt29 + gt30 + gt32; }
        }


        public decimal GT28
        {
            get {
                return gt31 + gt33;
            }

        }
        private decimal gt29;
        public decimal GT29
        {
            get { return gt29; }
            set { gt29= value;
            }
        }
        private decimal gt30;
        public decimal GT30
        {
            get { return gt30; }
            set { gt30 = value;
            }
        }
        private decimal gt31;
        public decimal GT31
        {
            get { return gt31; }
            set { gt31= value;
            }
        }
        private decimal gt32;
        public decimal GT32
        {
            get { return gt32; }
            set { gt32 = value;
              }
        }
        private decimal gt33;
        public decimal GT33
        {
            get { return gt33; }
            set { gt33= value;
            }
        }
        private decimal gt34;
        public decimal GT34
        {
            get { return gt34; }
            set { gt34 = value;
             }
        }
        private decimal gt35;
        public decimal GT35
        {
            get { return gt35; }
            set { gt35 = value; }
          
        }
        private decimal gt36;
        public decimal GT36
        {
            get { return gt36; }
            set { gt36 = value;

            }
        }
        private decimal gt37;
        public decimal GT37
        {
            get { return gt37; }
            set { gt37 = value;
            }
        }
   
        public decimal GT38
        {
            get { return GT24 + gt34 - gt36; }
     
        }
        public decimal GT39
        {
            get { return GT25+gt35-gt37; }
           
        }
        public decimal GT40
        {
            get {

                if ((GT39 - gt23 - gt11) > 0)
                    return GT39 - gt23 - gt11;
                else
                    return 0;
            }
        }

     
        public decimal GT41
        {
            get {
                if ((GT39 - gt23 - gt11) < 0)
                    return -(GT39 - gt23 - gt11);
                else
                    return 0;
            }
    
        }

        private decimal gt42;
        public decimal GT42
        {
            get { return gt42; }
            set { gt42 = value;
            }
        }

        public decimal GT43
        {
            get { return GT41 - gt42; }
        }
    }
}
