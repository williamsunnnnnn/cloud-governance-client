/**
 * Cloud Governance Api
 * No description provided (generated by Openapi Generator https://github.com/openapitools/openapi-generator)
 *
 * The version of the OpenAPI document: 1.0
 *
 * NOTE: This class is auto generated by OpenAPI Generator (https://openapi-generator.tech).
 * https://openapi-generator.tech
 *
 * OpenAPI Generator version: 4.2.2
 *
 * Do not edit the class manually.
 *
 */

(function(root, factory) {
  if (typeof define === 'function' && define.amd) {
    // AMD. Register as an anonymous module.
    define(['ApiClient', 'model/MembershipType', 'model/RecertificationActionType', 'model/RenewalItemAction', 'model/UserAccessType'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./MembershipType'), require('./RecertificationActionType'), require('./RenewalItemAction'), require('./UserAccessType'));
  } else {
    // Browser globals (root is window)
    if (!root.CgClient) {
      root.CgClient = {};
    }
    root.CgClient.MembershipRecertificationItem = factory(root.CgClient.ApiClient, root.CgClient.MembershipType, root.CgClient.RecertificationActionType, root.CgClient.RenewalItemAction, root.CgClient.UserAccessType);
  }
}(this, function(ApiClient, MembershipType, RecertificationActionType, RenewalItemAction, UserAccessType) {
  'use strict';



  /**
   * The MembershipRecertificationItem model module.
   * @module model/MembershipRecertificationItem
   * @version 1.0
   */

  /**
   * Constructs a new <code>MembershipRecertificationItem</code>.
   * @alias module:model/MembershipRecertificationItem
   * @class
   */
  var exports = function() {
    var _this = this;

  };

  /**
   * Constructs a <code>MembershipRecertificationItem</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/MembershipRecertificationItem} obj Optional instance to populate.
   * @return {module:model/MembershipRecertificationItem} The populated <code>MembershipRecertificationItem</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();
      if (data.hasOwnProperty('id')) {
        obj['id'] = ApiClient.convertToType(data['id'], 'String');
      }
      if (data.hasOwnProperty('instanceId')) {
        obj['instanceId'] = ApiClient.convertToType(data['instanceId'], 'String');
      }
      if (data.hasOwnProperty('type')) {
        obj['type'] = RecertificationActionType.constructFromObject(data['type']);
      }
      if (data.hasOwnProperty('taskId')) {
        obj['taskId'] = ApiClient.convertToType(data['taskId'], 'String');
      }
      if (data.hasOwnProperty('action')) {
        obj['action'] = RenewalItemAction.constructFromObject(data['action']);
      }
      if (data.hasOwnProperty('actionDescription')) {
        obj['actionDescription'] = ApiClient.convertToType(data['actionDescription'], 'String');
      }
      if (data.hasOwnProperty('user')) {
        obj['user'] = ApiClient.convertToType(data['user'], 'String');
      }
      if (data.hasOwnProperty('userDisplayName')) {
        obj['userDisplayName'] = ApiClient.convertToType(data['userDisplayName'], 'String');
      }
      if (data.hasOwnProperty('membershipType')) {
        obj['membershipType'] = MembershipType.constructFromObject(data['membershipType']);
      }
      if (data.hasOwnProperty('membershipTypeDescription')) {
        obj['membershipTypeDescription'] = ApiClient.convertToType(data['membershipTypeDescription'], 'String');
      }
      if (data.hasOwnProperty('accessType')) {
        obj['accessType'] = UserAccessType.constructFromObject(data['accessType']);
      }
      if (data.hasOwnProperty('accessTypeDescription')) {
        obj['accessTypeDescription'] = ApiClient.convertToType(data['accessTypeDescription'], 'String');
      }
    }
    return obj;
  }

  /**
   * @member {String} id
   */
  exports.prototype['id'] = undefined;
  /**
   * @member {String} instanceId
   */
  exports.prototype['instanceId'] = undefined;
  /**
   * @member {module:model/RecertificationActionType} type
   */
  exports.prototype['type'] = undefined;
  /**
   * @member {String} taskId
   */
  exports.prototype['taskId'] = undefined;
  /**
   * @member {module:model/RenewalItemAction} action
   */
  exports.prototype['action'] = undefined;
  /**
   * @member {String} actionDescription
   */
  exports.prototype['actionDescription'] = undefined;
  /**
   * @member {String} user
   */
  exports.prototype['user'] = undefined;
  /**
   * @member {String} userDisplayName
   */
  exports.prototype['userDisplayName'] = undefined;
  /**
   * @member {module:model/MembershipType} membershipType
   */
  exports.prototype['membershipType'] = undefined;
  /**
   * @member {String} membershipTypeDescription
   */
  exports.prototype['membershipTypeDescription'] = undefined;
  /**
   * @member {module:model/UserAccessType} accessType
   */
  exports.prototype['accessType'] = undefined;
  /**
   * @member {String} accessTypeDescription
   */
  exports.prototype['accessTypeDescription'] = undefined;



  return exports;
}));


