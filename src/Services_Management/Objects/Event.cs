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
    /// Event.
    /// </summary>
    // *** Start programmer edit section *** (Event CustomAttributes)

    // *** End programmer edit section *** (Event CustomAttributes)
    [AutoAltered()]
    [AccessType(ICSSoft.STORMNET.AccessType.none)]
    [View("EventE", new string[] {
            "EventDate as \'Event date\'",
            "EventType as \'Event type\'",
            "StartTime as \'Start time\'",
            "Duration as \'Duration\'",
            "Description as \'Description\'",
            "ServiceProvider as \'Service provider\'",
            "ServiceProvider.Name as \'Name\'"}, Hidden=new string[] {
            "ServiceProvider.Name"})]
    [MasterViewDefineAttribute("EventE", "ServiceProvider", ICSSoft.STORMNET.LookupTypeEnum.Standard, "", "Name")]
    [View("EventL", new string[] {
            "EventDate as \'Event date\'",
            "EventType as \'Event type\'",
            "StartTime as \'Start time\'",
            "Duration as \'Duration\'",
            "Description as \'Description\'",
            "ServiceProvider.Name as \'Name\'"})]
    public class Event : ICSSoft.STORMNET.DataObject
    {
        
        private IIS.Services_Management.tEventType fEventType;
        
        private System.DateTime fEventDate;
        
        private string fStartTime;
        
        private string fDuration;
        
        private string fDescription;
        
        private IIS.Services_Management.ServiceProvider fServiceProvider;
        
        // *** Start programmer edit section *** (Event CustomMembers)

        // *** End programmer edit section *** (Event CustomMembers)

        
        /// <summary>
        /// EventType.
        /// </summary>
        // *** Start programmer edit section *** (Event.EventType CustomAttributes)

        // *** End programmer edit section *** (Event.EventType CustomAttributes)
        public virtual IIS.Services_Management.tEventType EventType
        {
            get
            {
                // *** Start programmer edit section *** (Event.EventType Get start)

                // *** End programmer edit section *** (Event.EventType Get start)
                IIS.Services_Management.tEventType result = this.fEventType;
                // *** Start programmer edit section *** (Event.EventType Get end)

                // *** End programmer edit section *** (Event.EventType Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Event.EventType Set start)

                // *** End programmer edit section *** (Event.EventType Set start)
                this.fEventType = value;
                // *** Start programmer edit section *** (Event.EventType Set end)

                // *** End programmer edit section *** (Event.EventType Set end)
            }
        }
        
        /// <summary>
        /// EventDate.
        /// </summary>
        // *** Start programmer edit section *** (Event.EventDate CustomAttributes)

        // *** End programmer edit section *** (Event.EventDate CustomAttributes)
        public virtual System.DateTime EventDate
        {
            get
            {
                // *** Start programmer edit section *** (Event.EventDate Get start)

                // *** End programmer edit section *** (Event.EventDate Get start)
                System.DateTime result = this.fEventDate;
                // *** Start programmer edit section *** (Event.EventDate Get end)

                // *** End programmer edit section *** (Event.EventDate Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Event.EventDate Set start)

                // *** End programmer edit section *** (Event.EventDate Set start)
                this.fEventDate = value;
                // *** Start programmer edit section *** (Event.EventDate Set end)

                // *** End programmer edit section *** (Event.EventDate Set end)
            }
        }
        
        /// <summary>
        /// StartTime.
        /// </summary>
        // *** Start programmer edit section *** (Event.StartTime CustomAttributes)

        // *** End programmer edit section *** (Event.StartTime CustomAttributes)
        [StrLen(255)]
        public virtual string StartTime
        {
            get
            {
                // *** Start programmer edit section *** (Event.StartTime Get start)

                // *** End programmer edit section *** (Event.StartTime Get start)
                string result = this.fStartTime;
                // *** Start programmer edit section *** (Event.StartTime Get end)

                // *** End programmer edit section *** (Event.StartTime Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Event.StartTime Set start)

                // *** End programmer edit section *** (Event.StartTime Set start)
                this.fStartTime = value;
                // *** Start programmer edit section *** (Event.StartTime Set end)

                // *** End programmer edit section *** (Event.StartTime Set end)
            }
        }
        
        /// <summary>
        /// Duration.
        /// </summary>
        // *** Start programmer edit section *** (Event.Duration CustomAttributes)

        // *** End programmer edit section *** (Event.Duration CustomAttributes)
        [StrLen(255)]
        public virtual string Duration
        {
            get
            {
                // *** Start programmer edit section *** (Event.Duration Get start)

                // *** End programmer edit section *** (Event.Duration Get start)
                string result = this.fDuration;
                // *** Start programmer edit section *** (Event.Duration Get end)

                // *** End programmer edit section *** (Event.Duration Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Event.Duration Set start)

                // *** End programmer edit section *** (Event.Duration Set start)
                this.fDuration = value;
                // *** Start programmer edit section *** (Event.Duration Set end)

                // *** End programmer edit section *** (Event.Duration Set end)
            }
        }
        
        /// <summary>
        /// Description.
        /// </summary>
        // *** Start programmer edit section *** (Event.Description CustomAttributes)

        // *** End programmer edit section *** (Event.Description CustomAttributes)
        [StrLen(255)]
        public virtual string Description
        {
            get
            {
                // *** Start programmer edit section *** (Event.Description Get start)

                // *** End programmer edit section *** (Event.Description Get start)
                string result = this.fDescription;
                // *** Start programmer edit section *** (Event.Description Get end)

                // *** End programmer edit section *** (Event.Description Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Event.Description Set start)

                // *** End programmer edit section *** (Event.Description Set start)
                this.fDescription = value;
                // *** Start programmer edit section *** (Event.Description Set end)

                // *** End programmer edit section *** (Event.Description Set end)
            }
        }
        
        /// <summary>
        /// Event.
        /// </summary>
        // *** Start programmer edit section *** (Event.ServiceProvider CustomAttributes)

        // *** End programmer edit section *** (Event.ServiceProvider CustomAttributes)
        [NotNull()]
        public virtual IIS.Services_Management.ServiceProvider ServiceProvider
        {
            get
            {
                // *** Start programmer edit section *** (Event.ServiceProvider Get start)

                // *** End programmer edit section *** (Event.ServiceProvider Get start)
                IIS.Services_Management.ServiceProvider result = this.fServiceProvider;
                // *** Start programmer edit section *** (Event.ServiceProvider Get end)

                // *** End programmer edit section *** (Event.ServiceProvider Get end)
                return result;
            }
            set
            {
                // *** Start programmer edit section *** (Event.ServiceProvider Set start)

                // *** End programmer edit section *** (Event.ServiceProvider Set start)
                this.fServiceProvider = value;
                // *** Start programmer edit section *** (Event.ServiceProvider Set end)

                // *** End programmer edit section *** (Event.ServiceProvider Set end)
            }
        }
        
        /// <summary>
        /// Class views container.
        /// </summary>
        public class Views
        {
            
            /// <summary>
            /// "EventE" view.
            /// </summary>
            public static ICSSoft.STORMNET.View EventE
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("EventE", typeof(IIS.Services_Management.Event));
                }
            }
            
            /// <summary>
            /// "EventL" view.
            /// </summary>
            public static ICSSoft.STORMNET.View EventL
            {
                get
                {
                    return ICSSoft.STORMNET.Information.GetView("EventL", typeof(IIS.Services_Management.Event));
                }
            }
        }
    }
}
