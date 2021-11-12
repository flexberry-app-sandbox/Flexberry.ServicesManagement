import $ from 'jquery';
import EmberFlexberryTranslations from 'ember-flexberry/locales/en/translations';

import IISServices_ManagementCustomerLForm from './forms/i-i-s-services-management-customer-l';
import IISServices_ManagementCustomerRequestLForm from './forms/i-i-s-services-management-customer-request-l';
import IISServices_ManagementEventLForm from './forms/i-i-s-services-management-event-l';
import IISServices_ManagementFeedbackLForm from './forms/i-i-s-services-management-feedback-l';
import IISServices_ManagementServiceProviderLForm from './forms/i-i-s-services-management-service-provider-l';
import IISServices_ManagementTicketLForm from './forms/i-i-s-services-management-ticket-l';
import IISServices_ManagementCustomerEForm from './forms/i-i-s-services-management-customer-e';
import IISServices_ManagementCustomerRequestEForm from './forms/i-i-s-services-management-customer-request-e';
import IISServices_ManagementEventEForm from './forms/i-i-s-services-management-event-e';
import IISServices_ManagementFeedbackEForm from './forms/i-i-s-services-management-feedback-e';
import IISServices_ManagementServiceProviderEForm from './forms/i-i-s-services-management-service-provider-e';
import IISServices_ManagementTicketEForm from './forms/i-i-s-services-management-ticket-e';
import IISServices_ManagementCustomerRequestModel from './models/i-i-s-services-management-customer-request';
import IISServices_ManagementCustomerModel from './models/i-i-s-services-management-customer';
import IISServices_ManagementEventModel from './models/i-i-s-services-management-event';
import IISServices_ManagementFeedbackModel from './models/i-i-s-services-management-feedback';
import IISServices_ManagementServiceProviderModel from './models/i-i-s-services-management-service-provider';
import IISServices_ManagementTicketPositionModel from './models/i-i-s-services-management-ticket-position';
import IISServices_ManagementTicketModel from './models/i-i-s-services-management-ticket';

const translations = {};
$.extend(true, translations, EmberFlexberryTranslations);

$.extend(true, translations, {
  models: {
    'i-i-s-services-management-customer-request': IISServices_ManagementCustomerRequestModel,
    'i-i-s-services-management-customer': IISServices_ManagementCustomerModel,
    'i-i-s-services-management-event': IISServices_ManagementEventModel,
    'i-i-s-services-management-feedback': IISServices_ManagementFeedbackModel,
    'i-i-s-services-management-service-provider': IISServices_ManagementServiceProviderModel,
    'i-i-s-services-management-ticket-position': IISServices_ManagementTicketPositionModel,
    'i-i-s-services-management-ticket': IISServices_ManagementTicketModel
  },

  'application-name': 'Services_ management',

  forms: {
    loading: {
      'spinner-caption': 'Loading stuff, please wait for a moment...'
    },
    index: {
      greeting: 'Welcome to ember-flexberry test stand!'
    },

    application: {
      header: {
        menu: {
          'sitemap-button': {
            title: 'Menu'
          },
          'user-settings-service-checkbox': {
            caption: 'Use service to save user settings'
          },
          'show-menu': {
            caption: 'Show menu'
          },
          'hide-menu': {
            caption: 'Hide menu'
          },
          'language-dropdown': {
            caption: 'Application language',
            placeholder: 'Choose language'
          }
        },
        login: {
          caption: 'Login'
        },
        logout: {
          caption: 'Logout'
        }
      },

      footer: {
        'application-name': 'Services_ management',
        'application-version': {
          caption: 'Addon version {{version}}',
          title: 'It is version of ember-flexberry addon, which uses in this dummy application ' +
          '(npm version + commit sha). ' +
          'Click to open commit on GitHub.'
        }
      },

      sitemap: {
        'application-name': {
          caption: 'Services_ management',
          title: 'Services_ management'
        },
        'application-version': {
          caption: 'Addon version {{version}}',
          title: 'It is version of ember-flexberry addon, which uses in this dummy application ' +
          '(npm version + commit sha). ' +
          'Click to open commit on GitHub.'
        },
        index: {
          caption: 'Home',
          title: ''
        },
        'events-and-requests': {
          caption: 'Events and Requests',
          title: 'Events and Requests',
          'i-i-s-services-management-ticket-l': {
            caption: 'Ticket',
            title: ''
          },
          'i-i-s-services-management-feedback-l': {
            caption: 'Feedback',
            title: ''
          },
          'i-i-s-services-management-event-l': {
            caption: 'Event',
            title: ''
          },
          'i-i-s-services-management-customer-request-l': {
            caption: 'Customer request',
            title: ''
          }
        },
        profile: {
          caption: 'Profile',
          title: 'Profile',
          'i-i-s-services-management-customer-l': {
            caption: 'Customer Profile',
            title: 'Customer'
          }
        }
      }
    },

    'edit-form': {
      'save-success-message-caption': 'Save operation succeed',
      'save-success-message': 'Object saved',
      'save-error-message-caption': 'Save operation failed',
      'delete-success-message-caption': 'Delete operation succeed',
      'delete-success-message': 'Object deleted',
      'delete-error-message-caption': 'Delete operation failed'
    },
    'i-i-s-services-management-customer-l': IISServices_ManagementCustomerLForm,
    'i-i-s-services-management-customer-request-l': IISServices_ManagementCustomerRequestLForm,
    'i-i-s-services-management-event-l': IISServices_ManagementEventLForm,
    'i-i-s-services-management-feedback-l': IISServices_ManagementFeedbackLForm,
    'i-i-s-services-management-service-provider-l': IISServices_ManagementServiceProviderLForm,
    'i-i-s-services-management-ticket-l': IISServices_ManagementTicketLForm,
    'i-i-s-services-management-customer-e': IISServices_ManagementCustomerEForm,
    'i-i-s-services-management-customer-request-e': IISServices_ManagementCustomerRequestEForm,
    'i-i-s-services-management-event-e': IISServices_ManagementEventEForm,
    'i-i-s-services-management-feedback-e': IISServices_ManagementFeedbackEForm,
    'i-i-s-services-management-service-provider-e': IISServices_ManagementServiceProviderEForm,
    'i-i-s-services-management-ticket-e': IISServices_ManagementTicketEForm
  },

});

export default translations;
