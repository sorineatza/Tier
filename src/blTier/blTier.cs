using System;
using System.Data;
using dbTier;

namespace blTier
{
    public class PersonBLL
    {
        public DataTable GetPersons ()
        {
            try
            {
                PersonDAL objdal = new PersonDAL ();
                return objdal.Read ();
            } 
            catch
            {
                throw;
            }
        }

        public DataTable GetPersons (Int16 ID)
        {
            try
            {
                PersonDAL objdal = new PersonDAL ();
                return objdal.Read (ID);
            } 
            catch
            {
                throw;
            }
        }

        public void UpdateGrid(String sGrid)
        {
            try
            {
                PersonDAL objdal = new PersonDAL();
                objdal.Update(sGrid);
            }
            catch
            {
                throw;
            }
        }
    }
}