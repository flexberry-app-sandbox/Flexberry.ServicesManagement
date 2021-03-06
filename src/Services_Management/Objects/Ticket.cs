//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IIS.Services_Management
{
    using System;
    using System.Xml;
    using ICSSoft.STORMNET;
    
    
    // *** Start programmer edit section *** (Using statements)

    // *** End programmer edit section *** (Using statements)


    /// <summary>
    /// Ticket.
    /// </summary>
    // *** Start programmer edit section *** (Ticket CustomAttributes)

    // *** End programmer edit section *** (Ticket CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("TicketE", new string[] {
            "TicketDate as \'Ticket date\'",
            "Customer as \'Customer\'",
            "Customer.Name as \'Name\'"}, Hidden=new string[] {
            "Customer.Name"})]
    [AssociatedDetailViewAttribute("TicketE", "TicketPosition", "TicketPositionE", true, "", "Ticket position", true, new string[] {
            ""})]
    [MasterViewDefineAttribute("TicketE", "Customer", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Name")]
    [View("TicketL", new string[] {
            "TicketDate as \'Ticket date\'",
            "Customer.Name as \'Name\'"})]
    public class Ticket : ICSSoft.STORMNET.DataObject
    {
        
        private System.DateTime fTicketDate;
        
        private IIS.Services_Management.Customer fCustomer;
        
        private IIS.Services_Management.DetailArrayOfTicketPosition fTicketPosition;
        
        // *** Start programmer edit section *** (Ticket CustomMembers)

        // *** End programmer edit section *** (Ticket CustomMembers)

        
        /// <summary>
        /// TicketDate.
        /// </summary>
        // *** Start programmer edit section *** (Ticket.TicketDate CustomAttributes)

        // *** End programmer edit section *** (Ticket.TicketDate CustomAttributes)
        public virtual System.DateTime TicketDate
        {
            get
            {
                // *** Start programmer edit section *** (Ticket.TicketDate Get start)

                // *** End programmer edit section *** (Ticket.TicketDate Get start)
                System.DateTime result = this.fTicketDate;
                // *** Start programmer edit section *** (Ticket.TicketDate Get end)

                // *** End programmer edit section *** (Ticket.TicketDate Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Ticket.TicketDate Set start)

                // *** End programmer edit section *** (Ticket.TicketDate Set start)
                this.fTicketDate = value;
                // *** Start programmer edit section *** (Ticket.TicketDate Set end)

                // *** End programmer edit section *** (Ticket.TicketDate Set end)
            }
        }
        
        /// <summary>
        /// Ticket.
        /// </summary>
        // *** Start programmer edit section *** (Ticket.Customer CustomAttributes)

        // *** End programmer edit section *** (Ticket.Customer CustomAttributes)
        [NotNull()]
        public virtual IIS.Services_Management.Customer Customer
        {
            get
            {
                // *** Start programmer edit section *** (Ticket.Customer Get start)

                // *** End programmer edit section *** (Ticket.Customer Get start)
                IIS.Services_Management.Customer result = this.fCustomer;
                // *** Start programmer edit section *** (Ticket.Customer Get end)

                // *** End programmer edit section *** (Ticket.Customer Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Ticket.Customer Set start)

                // *** End programmer edit section *** (Ticket.Customer Set start)
                this.fCustomer = value;
                // *** Start programmer edit section *** (Ticket.Customer Set end)

                // *** End programmer edit section *** (Ticket.Customer Set end)
            }
        }
        
        /// <summary>
        /// Ticket.
        /// </summary>
        // *** Start programmer edit section *** (Ticket.TicketPosition CustomAttributes)

        // *** End programmer edit section *** (Ticket.TicketPosition CustomAttributes)
        public virtual IIS.Services_Management.DetailArrayOfTicketPosition TicketPosition
        {
            get
            {
                // *** Start programmer edit section *** (Ticket.TicketPosition Get start)

                // *** End programmer edit section *** (Ticket.TicketPosition Get start)
                if ((this.fTicketPosition == null))
                {
                    this.fTicketPosition = new IIS.Services_Management.DetailArrayOfTicketPosition(this);
                }
                IIS.Services_Management.DetailArrayOfTicketPosition result = this.fTicketPosition;
                // *** Start programmer edit section *** (Ticket.TicketPosition Get end)

                // *** End programmer edit section *** (Ticket.TicketPosition Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Ticket.TicketPosition Set start)

                // *** End programmer edit section *** (Ticket.TicketPosition Set start)
                this.fTicketPosition = value;
                // *** Start programmer edit section *** (Ticket.TicketPosition Set end)

                // *** End programmer edit section *** (Ticket.TicketPosition Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "TicketE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View TicketE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("TicketE", typeof(IIS.Services_Management.Ticket));
                }
            }
            
            /// <summary>
            /// "TicketL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View TicketL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("TicketL", typeof(IIS.Services_Management.Ticket));
                }
            }
        }
    }
}
