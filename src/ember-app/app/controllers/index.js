import Controller from '@ember/controller';
import { computed } from '@ember/object';

export default Controller.extend({
  sitemap: computed('i18n.locale', function () {
    let i18n = this.get('i18n');

    return {
      nodes: [
        {
          link: 'index',
          icon: 'home',
          caption: i18n.t('forms.application.sitemap.index.caption'),
          title: i18n.t('forms.application.sitemap.index.title'),
          children: null
        }, {
          link: null,
          icon: 'list',
          caption: i18n.t('forms.application.sitemap.events-and-requests.caption'),
          title: i18n.t('forms.application.sitemap.events-and-requests.title'),
          children: [{
            link: 'i-i-s-services-management-ticket-l',
            caption: i18n.t('forms.application.sitemap.events-and-requests.i-i-s-services-management-ticket-l.caption'),
            title: i18n.t('forms.application.sitemap.events-and-requests.i-i-s-services-management-ticket-l.title'),
            icon: 'calendar',
            children: null
          }, {
            link: 'i-i-s-services-management-feedback-l',
            caption: i18n.t('forms.application.sitemap.events-and-requests.i-i-s-services-management-feedback-l.caption'),
            title: i18n.t('forms.application.sitemap.events-and-requests.i-i-s-services-management-feedback-l.title'),
            icon: 'list',
            children: null
          }, {
            link: 'i-i-s-services-management-event-l',
            caption: i18n.t('forms.application.sitemap.events-and-requests.i-i-s-services-management-event-l.caption'),
            title: i18n.t('forms.application.sitemap.events-and-requests.i-i-s-services-management-event-l.title'),
            icon: 'briefcase',
            children: null
          }, {
            link: 'i-i-s-services-management-customer-request-l',
            caption: i18n.t('forms.application.sitemap.events-and-requests.i-i-s-services-management-customer-request-l.caption'),
            title: i18n.t('forms.application.sitemap.events-and-requests.i-i-s-services-management-customer-request-l.title'),
            icon: 'book',
            children: null
          }]
        }, {
          link: null,
          icon: 'list',
          caption: i18n.t('forms.application.sitemap.profile.caption'),
          title: i18n.t('forms.application.sitemap.profile.title'),
          children: [{
            link: 'i-i-s-services-management-customer-l',
            caption: i18n.t('forms.application.sitemap.profile.i-i-s-services-management-customer-l.caption'),
            title: i18n.t('forms.application.sitemap.profile.i-i-s-services-management-customer-l.title'),
            icon: 'folder open',
            children: null
          }]
        }, {
          link: null,
          icon: 'list',
          caption: i18n.t('forms.application.sitemap.common.caption'),
          title: i18n.t('forms.application.sitemap.common.title'),
          children: [{
            link: 'i-i-s-services-management-service-provider-l',
            caption: i18n.t('forms.application.sitemap.common.i-i-s-services-management-service-provider-l.caption'),
            title: i18n.t('forms.application.sitemap.common.i-i-s-services-management-service-provider-l.title'),
            icon: 'file',
            children: null
          }]
        }
      ]
    };
  }),
})