import FlexberryEnum from 'ember-flexberry-data/transforms/flexberry-enum';
import tEventTypeEnum from '../enums/i-i-s-services-management-t-event-type';

export default FlexberryEnum.extend({
  enum: tEventTypeEnum,
  sourceType: 'IIS.Services_Management.tEventType'
});
