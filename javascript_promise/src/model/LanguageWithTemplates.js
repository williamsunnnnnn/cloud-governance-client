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
    define(['ApiClient', 'model/SiteTemplate'], factory);
  } else if (typeof module === 'object' && module.exports) {
    // CommonJS-like environments that support module.exports, like Node.
    module.exports = factory(require('../ApiClient'), require('./SiteTemplate'));
  } else {
    // Browser globals (root is window)
    if (!root.CgClient) {
      root.CgClient = {};
    }
    root.CgClient.LanguageWithTemplates = factory(root.CgClient.ApiClient, root.CgClient.SiteTemplate);
  }
}(this, function(ApiClient, SiteTemplate) {
  'use strict';



  /**
   * The LanguageWithTemplates model module.
   * @module model/LanguageWithTemplates
   * @version 1.0
   */

  /**
   * Constructs a new <code>LanguageWithTemplates</code>.
   * @alias module:model/LanguageWithTemplates
   * @class
   */
  var exports = function() {
    var _this = this;

  };

  /**
   * Constructs a <code>LanguageWithTemplates</code> from a plain JavaScript object, optionally creating a new instance.
   * Copies all relevant properties from <code>data</code> to <code>obj</code> if supplied or a new instance if not.
   * @param {Object} data The plain JavaScript object bearing properties of interest.
   * @param {module:model/LanguageWithTemplates} obj Optional instance to populate.
   * @return {module:model/LanguageWithTemplates} The populated <code>LanguageWithTemplates</code> instance.
   */
  exports.constructFromObject = function(data, obj) {
    if (data) {
      obj = obj || new exports();
      if (data.hasOwnProperty('languageId')) {
        obj['languageId'] = ApiClient.convertToType(data['languageId'], 'Number');
      }
      if (data.hasOwnProperty('defaultTemplate')) {
        obj['defaultTemplate'] = ApiClient.convertToType(data['defaultTemplate'], 'String');
      }
      if (data.hasOwnProperty('templates')) {
        obj['templates'] = ApiClient.convertToType(data['templates'], [SiteTemplate]);
      }
    }
    return obj;
  }

  /**
   * @member {Number} languageId
   */
  exports.prototype['languageId'] = undefined;
  /**
   * @member {String} defaultTemplate
   */
  exports.prototype['defaultTemplate'] = undefined;
  /**
   * @member {Array.<module:model/SiteTemplate>} templates
   */
  exports.prototype['templates'] = undefined;



  return exports;
}));


