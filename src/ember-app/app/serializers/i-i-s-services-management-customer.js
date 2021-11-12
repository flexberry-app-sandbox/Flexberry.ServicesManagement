import { Serializer as CustomerSerializer } from
  '../mixins/regenerated/serializers/i-i-s-services-management-customer';
import __ApplicationSerializer from './application';

export default __ApplicationSerializer.extend(CustomerSerializer, {
  /**
  * Field name where object identifier is kept.
  */
  primaryKey: '__PrimaryKey'
});
