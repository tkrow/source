using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_3_Winter_2019
{
    // Instructions //

    // Copy and paste this code into a new console project named "Exam_3_Winter_2019".

    // Write or change code to complete the following.
    // Note: There is more than one way to go about some of these.

    /* 
       1. Complete the non-default constructor for Classroom to set its data members to
       whatever arguments are passed to it.
       2. Change the default constructor of the Classroom class to set all new Classroom
       objects that use the default constructor have 20 seats, has 'hasComputers' values set to false,
       and has 'hasProjector' value set to true.
       3. Add code so that all new instances of ComputerClassroom have their 'hasComputers'
       value set to true.
       4. Add or change code so that all new MedicalLabClasssroom objects have their 'hasOverheadProjector' value
       set to false.
       5. Create a ToString() method for the Classroom class.
       BONUS - Create a ToString() method for the subclasses of Classroom that calls the Classroom class's
       ToString() method.
    */

    class Program
    {
        static void Main(string[] args)
        {
            ComputerClassroom computerClassroom1 = new ComputerClassroom();
            MedicalLabClassroom medicalLabClassroom1 = new MedicalLabClassroom();

            Console.WriteLine(computerClassroom1.ToString(20, true, true));
            Console.Write("\n");
            Console.WriteLine(medicalLabClassroom1.ToString(20, false, true));

            Console.ReadKey();
        }

    }

    class Classroom
    {
        private byte numberOfSeats;
        private bool hasComputers;
        private bool hasOverheadProjector;

        public Classroom() : this(20, false, true)
        {
            
        }

        public Classroom(byte numberOfSeats, bool hasComputers, bool hasOverheadProjector)
        {
            this.numberOfSeats = numberOfSeats;
            this.hasComputers = hasComputers;
            this.hasOverheadProjector = hasOverheadProjector;
        }

        public byte getNumberOfSeats()
        {
            return this.numberOfSeats;
        }
        public void setNumberOfSeats(byte numberOfSeats)
        {
            this.numberOfSeats = numberOfSeats;
        }

        public bool getHasComputers()
        {
            return this.hasComputers;
        }
        public void setHasComputers(bool hasComputers)
        {
            this.hasComputers = hasComputers;
        }

        public bool getHasOverheadProjector()
        {
            return this.hasOverheadProjector;
        }
        public void setHasOverheadProjector(bool hasOverheadProjector)
        {
            this.hasOverheadProjector = hasOverheadProjector;
        }

        public string ToString(byte numberOfSeats, bool hasComputers, bool hasOverheadProjector)
        {
            return ("Number of Seats: " + numberOfSeats + "\n" +
                    "Has Computers: " + hasComputers + "\n" +
                    "Has Overhead Projector: " + hasOverheadProjector);
        }
    }

    class ComputerClassroom : Classroom
    {
        public ComputerClassroom()
        {

        }
    
        public ComputerClassroom(byte numberOfSeats, bool boolhasComputers, bool hasOverheadProjector) : base(numberOfSeats, true, true)
        {

        } 


    }

    class MedicalLabClassroom : Classroom
    {
        public MedicalLabClassroom()
        {

        }

        public MedicalLabClassroom(byte numberOfSeats, bool boolhasComputers, bool hasOverheadProjector) : base(numberOfSeats, false, false)
        {

        }

        
    }

}