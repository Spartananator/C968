using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Inventory
    {
        public void AddPart(inHouse part)
        {

            AllParts.Add(part);
        }
        public void AddPart(outSourced part)
        {

            AllParts.Add(part);
        }




        public bool RemovePart(int partID)
        {
            foreach (Part part in AllParts)
            {
                if (part.ID == partID)
                {
                    AllParts.Remove(part);
                    
                    return true;
                }
                
            }
            return false;
        }






        public Part LookupPart(int partID)
        {
            foreach (Part part in AllParts)
            {
                if (part.ID == partID)
                {
                    return part;
                }
                
            }

            return null;
        }






        public void UpdatePart(int id, inHouse part)
        {
            for (int i = 0; i < AllParts.Count; i++)
            {
                if (AllParts[i].ID == id)
                {
                    AllParts[i] = part;
                }
            }
        }
        public void UpdatePart(int id, outSourced part)
        {
            for (int i = 0; i < AllParts.Count; i++)
            {
                if (AllParts[i].ID == id)
                {
                    AllParts[i] = part;
                }
            }
        }
    }
}
