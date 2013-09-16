using System;
using System.Windows.Forms;

namespace RaceOfAMadButtons
{
    public class ComparableButton:Button,IComparable
    {
        #region CompareTo
        public int CompareTo(object obj)
        {
            ComparableButton temp = obj as ComparableButton;

            if (temp != null)
            {
                if (this.Location.X > temp.Location.X)
                {
                    return -1;
                }
                if (this.Location.X < temp.Location.X)
                {
                    return 1;
                }
                return 0;
            }
            MessageBox.Show("Error!!!");
            return 0;
        }
        #endregion
    }
}
