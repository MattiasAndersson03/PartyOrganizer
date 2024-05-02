using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PartyOrganizer
{
    class Party
    {
        // Constructor to initialize the guest list with a maximum number of guests
        public Party(int maxNumberOfGuests)
        {
            guestList = new string[maxNumberOfGuests];
        }

        private string[] guestList; // Array to store the names of the guests
        private double costPerCapita; // Cost per guest
        private double feePerCapita; // Fee per guest

        // Method to retrieve the guest list without empty slots
        public string[] GetGuestList()
        {
            int size = NumOfGuests();

            if (size <= 0)
                return null;

            string[] guests = new string[size];

            for (int i = 0, j = 0; i < guestList.Length; i++)
            {
                if (!string.IsNullOrEmpty(guestList[i]))
                {
                    guests[j++] = guestList[i];
                }
            }

            return guests;
        }

        // Property to get or set the cost per guest
        public double CostPerGuest
        {
            get { return costPerCapita; }
            set
            {
                if (value >= 0)
                    costPerCapita = value;
            }
        }

        // Property to get or set the fee per guest
        public double FeePerGuest
        {
            get { return feePerCapita; }
            set
            {
                if (value >= 0)
                    feePerCapita = value;
            }
        }

        // Method to get the number of guests currently in the list
        public int NumOfGuests()
        {
            int numGuests = 0;

            for (int i = 0; i < guestList.Length; i++)
            {
                if (!string.IsNullOrEmpty(guestList[i]))
                {
                    numGuests++;
                }
            }

            return numGuests;
        }

        // Method to construct the full name from first and last name
        private string FullName(string firstName, string lastName)
        {
            return lastName.ToUpper() + ", " + firstName;
        }

        // Method to add a new guest to the list
        public bool AddNewGuest(string firstName, string lastName)
        {
            bool ok = true;
            int EmptyPos = FindEmptyPos();

            if (EmptyPos != -1)
            {
                guestList[EmptyPos] = FullName(firstName, lastName);
            }
            else
                return false;

            return ok;
        }

        // Method to calculate the total cost of the party
        public double CalcTotalCost()
        {
            return costPerCapita * NumOfGuests();
        }

        // Method to calculate the total fees of the party
        public double CalcTotalFees()
        {
            return feePerCapita * NumOfGuests();
        }

        // Method to delete a guest from the list 
        public bool DeleteGuest(int selectedIndex)
        {
            int size = GetGuestList().Length;

            if (size <= 0)
                return false;

            int[] map = new int[size];

            for (int i = 0, j = 0; i < guestList.Length; i++)
            {
                if (!string.IsNullOrEmpty(guestList[i]))
                {
                    map[j++] = i;
                }
            }

            guestList[map[selectedIndex]] = string.Empty;
            return true;
        }

        // Method to change the name of a guest in the list by index
        public bool ChangeGuest(int selectedIndex, string firstName, string lastName)
        {
            int size = GetGuestList().Length;

            if (size <= 0)
                return false;

            int[] map = new int[size];

            for (int i = 0, j = 0; i < guestList.Length; i++)
            {
                if (!string.IsNullOrEmpty(guestList[i]))
                {
                    map[j++] = i;
                }
            }

            guestList[map[selectedIndex]] = FullName(firstName, lastName);
            return true;
        }

        // Method to retrieve the first and last name of a guest by index
        public string[] GetGuestName(int selectedIndex)
        {
            int size = GetGuestList().Length;

            if (size <= 0)
                return null;

            int[] map = new int[size];

            for (int i = 0, j = 0; i < guestList.Length; i++)
            {
                if (!string.IsNullOrEmpty(guestList[i]))
                {
                    map[j++] = i;
                }
            }

            string temp = guestList[map[selectedIndex]];
            char delimiter = ',';
            string[] substrings = temp.Split(delimiter);

            return substrings;
        }

        // Method to find the index of the first empty position in the guest list
        private int FindEmptyPos()
        {
            int EmptyPos = -1;

            for (int i = 0; i < guestList.Length; i++)
            {
                if (string.IsNullOrEmpty(guestList[i]))
                {
                    EmptyPos = i;
                    break;
                }
            }

            return EmptyPos;
        }
    }
}
