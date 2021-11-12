import { Serializer as TicketPositionSerializer } from
  '../mixins/regenerated/serializers/i-i-s-services-management-ticket-position';
import __ApplicationSerializer from './application';

export default __ApplicationSerializer.extend(TicketPositionSerializer, {
  /**
  * Field name where object identifier is kept.
  */
  primaryKey: '__PrimaryKey'
});
