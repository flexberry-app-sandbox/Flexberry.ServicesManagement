﻿//------------------------------------------------------------------------------
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
    /// Feedback.
    /// </summary>
    // *** Start programmer edit section *** (Feedback CustomAttributes)

    // *** End programmer edit section *** (Feedback CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("FeedbackE", new string[] {
            "Ranking as \'Ranking\'",
            "FeedbackText as \'Feedback text\'",
            "Customer as \'Customer\'",
            "Customer.Name as \'Name\'",
            "Event as \'Event\'",
            "Event.StartTime as \'Start time\'"}, Hidden=new string[] {
            "Customer.Name",
            "Event.StartTime"})]
    [MasterViewDefineAttribute("FeedbackE", "Customer", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Name")]
    [MasterViewDefineAttribute("FeedbackE", "Event", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "StartTime")]
    [View("FeedbackL", new string[] {
            "Ranking as \'Ranking\'",
            "FeedbackText as \'Feedback text\'",
            "Customer.Name as \'Name\'",
            "Event.StartTime as \'Start time\'"})]
    public class Feedback : ICSSoft.STORMNET.DataObject
    {
        
        private int fRanking;
        
        private string fFeedbackText;
        
        private IIS.Services_Management.Customer fCustomer;
        
        private IIS.Services_Management.Event fEvent;
        
        // *** Start programmer edit section *** (Feedback CustomMembers)

        // *** End programmer edit section *** (Feedback CustomMembers)

        
        /// <summary>
        /// Ranking.
        /// </summary>
        // *** Start programmer edit section *** (Feedback.Ranking CustomAttributes)

        // *** End programmer edit section *** (Feedback.Ranking CustomAttributes)
        public virtual int Ranking
        {
            get
            {
                // *** Start programmer edit section *** (Feedback.Ranking Get start)

                // *** End programmer edit section *** (Feedback.Ranking Get start)
                int result = this.fRanking;
                // *** Start programmer edit section *** (Feedback.Ranking Get end)

                // *** End programmer edit section *** (Feedback.Ranking Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Feedback.Ranking Set start)

                // *** End programmer edit section *** (Feedback.Ranking Set start)
                this.fRanking = value;
                // *** Start programmer edit section *** (Feedback.Ranking Set end)

                // *** End programmer edit section *** (Feedback.Ranking Set end)
            }
        }
        
        /// <summary>
        /// FeedbackText.
        /// </summary>
        // *** Start programmer edit section *** (Feedback.FeedbackText CustomAttributes)

        // *** End programmer edit section *** (Feedback.FeedbackText CustomAttributes)
        [StrLen(255)]
        public virtual string FeedbackText
        {
            get
            {
                // *** Start programmer edit section *** (Feedback.FeedbackText Get start)

                // *** End programmer edit section *** (Feedback.FeedbackText Get start)
                string result = this.fFeedbackText;
                // *** Start programmer edit section *** (Feedback.FeedbackText Get end)

                // *** End programmer edit section *** (Feedback.FeedbackText Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Feedback.FeedbackText Set start)

                // *** End programmer edit section *** (Feedback.FeedbackText Set start)
                this.fFeedbackText = value;
                // *** Start programmer edit section *** (Feedback.FeedbackText Set end)

                // *** End programmer edit section *** (Feedback.FeedbackText Set end)
            }
        }
        
        /// <summary>
        /// Feedback.
        /// </summary>
        // *** Start programmer edit section *** (Feedback.Customer CustomAttributes)

        // *** End programmer edit section *** (Feedback.Customer CustomAttributes)
        [NotNull()]
        public virtual IIS.Services_Management.Customer Customer
        {
            get
            {
                // *** Start programmer edit section *** (Feedback.Customer Get start)

                // *** End programmer edit section *** (Feedback.Customer Get start)
                IIS.Services_Management.Customer result = this.fCustomer;
                // *** Start programmer edit section *** (Feedback.Customer Get end)

                // *** End programmer edit section *** (Feedback.Customer Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Feedback.Customer Set start)

                // *** End programmer edit section *** (Feedback.Customer Set start)
                this.fCustomer = value;
                // *** Start programmer edit section *** (Feedback.Customer Set end)

                // *** End programmer edit section *** (Feedback.Customer Set end)
            }
        }
        
        /// <summary>
        /// Feedback.
        /// </summary>
        // *** Start programmer edit section *** (Feedback.Event CustomAttributes)

        // *** End programmer edit section *** (Feedback.Event CustomAttributes)
        [NotNull()]
        public virtual IIS.Services_Management.Event Event
        {
            get
            {
                // *** Start programmer edit section *** (Feedback.Event Get start)

                // *** End programmer edit section *** (Feedback.Event Get start)
                IIS.Services_Management.Event result = this.fEvent;
                // *** Start programmer edit section *** (Feedback.Event Get end)

                // *** End programmer edit section *** (Feedback.Event Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Feedback.Event Set start)

                // *** End programmer edit section *** (Feedback.Event Set start)
                this.fEvent = value;
                // *** Start programmer edit section *** (Feedback.Event Set end)

                // *** End programmer edit section *** (Feedback.Event Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "FeedbackE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View FeedbackE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("FeedbackE", typeof(IIS.Services_Management.Feedback));
                }
            }
            
            /// <summary>
            /// "FeedbackL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View FeedbackL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("FeedbackL", typeof(IIS.Services_Management.Feedback));
                }
            }
        }
    }
}