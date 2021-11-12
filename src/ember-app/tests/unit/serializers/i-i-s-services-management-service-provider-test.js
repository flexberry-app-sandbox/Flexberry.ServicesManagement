import { moduleForModel, test } from 'ember-qunit';

moduleForModel('i-i-s-services-management-service-provider', 'Unit | Serializer | i-i-s-services-management-service-provider', {
  // Specify the other units that are required for this test.
  needs: [
    'serializer:i-i-s-services-management-service-provider',
    'service:syncer',
    'transform:file',
    'transform:decimal',
    'transform:guid',

    'transform:i-i-s-services-management-t-event-type',

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
  ],
});

// Replace this with your real tests.
test('it serializes records', function(assert) {
  let record = this.subject();

  let serializedRecord = record.serialize();

  assert.ok(serializedRecord);
});
