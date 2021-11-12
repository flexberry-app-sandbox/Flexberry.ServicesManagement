import EmberRouter from '@ember/routing/router';
import config from './config/environment';

const Router = EmberRouter.extend({
  location: config.locationType
});

Router.map(function () {
  this.route('i-i-s-services-management-customer-l');
  this.route('i-i-s-services-management-customer-e',
  { path: 'i-i-s-services-management-customer-e/:id' });
  this.route('i-i-s-services-management-customer-e.new',
  { path: 'i-i-s-services-management-customer-e/new' });
  this.route('i-i-s-services-management-customer-request-l');
  this.route('i-i-s-services-management-customer-request-e',
  { path: 'i-i-s-services-management-customer-request-e/:id' });
  this.route('i-i-s-services-management-customer-request-e.new',
  { path: 'i-i-s-services-management-customer-request-e/new' });
  this.route('i-i-s-services-management-event-l');
  this.route('i-i-s-services-management-event-e',
  { path: 'i-i-s-services-management-event-e/:id' });
  this.route('i-i-s-services-management-event-e.new',
  { path: 'i-i-s-services-management-event-e/new' });
  this.route('i-i-s-services-management-feedback-l');
  this.route('i-i-s-services-management-feedback-e',
  { path: 'i-i-s-services-management-feedback-e/:id' });
  this.route('i-i-s-services-management-feedback-e.new',
  { path: 'i-i-s-services-management-feedback-e/new' });
  this.route('i-i-s-services-management-service-provider-l');
  this.route('i-i-s-services-management-service-provider-e',
  { path: 'i-i-s-services-management-service-provider-e/:id' });
  this.route('i-i-s-services-management-service-provider-e.new',
  { path: 'i-i-s-services-management-service-provider-e/new' });
  this.route('i-i-s-services-management-ticket-l');
  this.route('i-i-s-services-management-ticket-e',
  { path: 'i-i-s-services-management-ticket-e/:id' });
  this.route('i-i-s-services-management-ticket-e.new',
  { path: 'i-i-s-services-management-ticket-e/new' });
});

export default Router;
