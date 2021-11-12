import { moduleForModel, test } from 'ember-qunit';

moduleForModel('i-i-s-services-management-event', 'Unit | Model | i-i-s-services-management-event', {
  // Specify the other units that are required for this test.
  needs: [
    'model:i-i-s-services-management-customer-request',
    'model:i-i-s-services-management-customer',
    'model:i-i-s-services-management-event',
    'model:i-i-s-services-management-feedback',
    'model:i-i-s-services-management-service-provider',
    'model:i-i-s-services-management-ticket-position',
    'model:i-i-s-services-management-ticket',
    'validator:ds-error',
    'validator:presence',
    'validator:number',
    'validator:date',
    'validator:belongs-to',
    'validator:has-many',
    'service:syncer',
  ],
});

test('it exists', function(assert) {
  let model = this.subject();

  // let store = this.store();
  assert.ok(!!model);
});
