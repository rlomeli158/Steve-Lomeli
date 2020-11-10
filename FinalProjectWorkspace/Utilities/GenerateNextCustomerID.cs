using FinalProjectWorkspace.DAL;
using System;
using System.Linq;


namespace Lomeli_Steve_HW5.Utilities
{
    public static class GenerateNextCustomerID
    {
        public static Int32 GetNextCustomerID(AppDbContext _context)
        {
            //set a constant to designate where the order numbers 
            //should start
            const Int32 START_NUMBER = 70001;

            Int32 intMaxCustomerNumber; //the current maximum order number
            Int32 intNextCustomerNumber; //the order number for the next class

            if (_context.Users.Count() == 0) //there are no orders in the database yet
            {
                intMaxCustomerNumber = START_NUMBER; //order numbers start at 70001
            }
            else
            {
                intMaxCustomerNumber = Int32.Parse(_context.Users.Max(c => c.Id)); //this is the highest number in the database right now
            }

            //You added records to the datbase before you realized 
            //that you needed this and now you have numbers less than 100 
            //in the database
            if (intMaxCustomerNumber < START_NUMBER)
            {
                intMaxCustomerNumber = START_NUMBER;
            }

            //add one to the current max to find the next one
            intNextCustomerNumber = intMaxCustomerNumber + 1;

            //return the value
            return intNextCustomerNumber; //Might have to change this to string depending on ID data type
        }

    }
}

/******************
 * 
 * TO ACTUALLY ASSIGN THE CUSTOMER ID PULLED FROM HW 5
 * //Set order number automatically
   order.OrderNumber = Utilities.GenerateNextOrderNumber.GetNextOrderNumber(_context);

I think that it would be something like
Id = Utilities.GenerateNextCustomerID.GetNextCustomerID(_context);
 * 
 * 
 */
