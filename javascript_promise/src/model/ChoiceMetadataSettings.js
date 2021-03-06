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
    define(['ApiClient', 'model/ChoiceType'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./ChoiceType'));
  } else {
    // Browser globals (root is window)
    if (!root.CgClient) {
      root.CgClient = {};
    }
    root.CgClient.ChoiceMetadataSettings = factory(root.CgClient.ApiClient, root.CgClient.ChoiceType);
  }
}(this, function(ApiClient, ChoiceType) {
  'use strict';



  /**
   * The ChoiceMetadataSettings model module.
   * @module model/ChoiceMetadataSettings
   * @version 1.0
   */

  /**
   * Constructs a new <code>ChoiceMetadataSettings</code>.
   * @alias module:model/ChoiceMetadataSettings
   * @class
   */
  var exports = function() {
    var _this = this;

  };

  /**
   * Constructs a <code>ChoiceMetadataSettings</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/ChoiceMetadataSettings} obj Optional instance to populate.
   * @return {module:model/ChoiceMetadataSettings} The populated <code>ChoiceMetadataSettings</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();
      if (data.hasOwnProperty('choices')) {
        obj['choices'] = ApiClient.convertToType(data['choices'], ['String']);
      }
      if (data.hasOwnProperty('value')) {
        obj['value'] = ApiClient.convertToType(data['value'], ['String']);
      }
      if (data.hasOwnProperty('choiceType')) {
        obj['choiceType'] = ChoiceType.constructFromObject(data['choiceType']);
      }
    }
    return obj;
  }

  /**
   * @member {Array.<String>} choices
   */
  exports.prototype['choices'] = undefined;
  /**
   * @member {Array.<String>} value
   */
  exports.prototype['value'] = undefined;
  /**
   * @member {module:model/ChoiceType} choiceType
   */
  exports.prototype['choiceType'] = undefined;



  return exports;
}));


