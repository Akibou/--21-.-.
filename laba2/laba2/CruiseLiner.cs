using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace laba2
{
    public class CruiseLiner : Ship, IComparable<CruiseLiner>, IEquatable<Ship>
   
    {
        public int CompareTo(CruiseLiner other)
        {
            var res = (this is Ship).CompareTo(other is Ship);
            if (res != 0)
            {
                return res;
            }
            if (BorderLine != other.BorderLine)
            {
                return BorderLine.CompareTo(other.BorderLine);
            }
            if (TopLine != other.TopLine)
            {
                return TopLine.CompareTo(other.TopLine);
            }
            if (RoundLine != other.RoundLine)
            {
                return RoundLine.CompareTo(other.RoundLine);
            }
            if (dopColor != other.dopColor)
            {
                dopColor.Name.CompareTo(other.dopColor.Name);
            }
            return 0;
        }
        public bool Equals (CruiseLiner other)
        {
            var res = (this is Ship).Equals(other is Ship);
            if (!res) { return res; }
            if (BorderLine != other.BorderLine)
            {
                return false;
            }
            if (TopLine != other.TopLine)
            {
                return false;
            }
            if (RoundLine != other.RoundLine)
            {
                return false;
            }
            if (dopColor != other.dopColor)
            {
                return false;
            }
            return true;
        }

        public override bool Equals(object obj)
        {
            if (obj == null) { return false; }
            CruiseLiner shipObj = obj as CruiseLiner;
            if (shipObj == null) { return false; }
            else { return Equals(shipObj); }
        }
        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

        private bool BorderLine;
        private bool TopLine;
        private bool RoundLine;
        private Color dopColor;
        private bool Rest;

        public CruiseLiner(int maxSpeed,
                           int maxCountPassenget,
                           double weight,
                           Color color,
                           bool BorderLine,
                           bool TopLine,
                           bool RoundLine,
                           Color dopColor, 
                           bool Rest,
                           bool Bass) : base(maxSpeed, maxCountPassenget, weight, color)

        {
            this.BorderLine = BorderLine;
            this.TopLine = TopLine;
            this.RoundLine = RoundLine;
            this.dopColor = dopColor;


        }
    
        public CruiseLiner(string info) : base(info)
        {
            string[] strs = info.Split(';');
            if (strs.Length == 8)
            {
                MaxSpeed = Convert.ToInt32(strs[0]);
                MaxCountPassengers = Convert.ToInt32(strs[1]);
                Weight = Convert.ToInt32(strs[2]);
                ColorBody = Color.FromName(strs[3]);
                BorderLine = Convert.ToBoolean(strs[4]);
                TopLine = Convert.ToBoolean(strs[5]);
                RoundLine = Convert.ToBoolean(strs[6]);
                dopColor = Color.FromName(strs[7]);
            }
        }

        protected override void drawLiner(Graphics g)
        {

            base.drawLiner(g);
            Brush dop_color = new SolidBrush(dopColor);
            Pen pen = new Pen(Color.Black);

            if (BorderLine)
            {
                //Боковая линия
                PointF[] border_line = {
                    new PointF(startPosX + 5 , startPosY +75),
                    new PointF(startPosX + 85 , startPosY + 75),
                    new PointF(startPosX + 80 , startPosY + 90),
                    new PointF(startPosX + 7 , startPosY + 90)
                };

                g.FillPolygon(dop_color, border_line);
                g.DrawPolygon(pen, border_line);

            }
            if (TopLine)
            {
                //Линия на трубе
                PointF[] top_line = {
                    new PointF(startPosX + 20 , startPosY + 17),
                    new PointF(startPosX + 20 , startPosY + 23),
                    new PointF(startPosX + 30 , startPosY + 23),
                    new PointF(startPosX + 30 , startPosY + 17)
                };

                g.FillPolygon(dop_color, top_line);
                g.DrawPolygon(pen, top_line);
            }
            if (RoundLine)
            {
                g.FillEllipse(dop_color, startPosX + 20, startPosY + 70, 15, -15);
                g.DrawEllipse(pen, startPosX + 20, startPosY + 70, 15, -15);
            }

        }
        public void setDopColor(Color color)
        {
            dopColor = color;
        }

        public override string GetInfo()
        {
            return MaxSpeed + ";" + MaxCountPassengers + ";" + Weight + ";" + ColorBody.Name+';'+BorderLine+';'+TopLine+';'+ RoundLine+';'+ dopColor.Name;
        }
    }
}