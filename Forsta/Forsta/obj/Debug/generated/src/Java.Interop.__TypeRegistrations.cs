using System;
using System.Collections.Generic;
using Android.Runtime;

namespace Java.Interop {

	partial class __TypeRegistrations {

		public static void RegisterPackages ()
		{
#if MONODROID_TIMING
			var start = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages start: " + (start - new DateTime (1970, 1, 1)).TotalMilliseconds);
#endif // def MONODROID_TIMING
			Java.Interop.TypeManager.RegisterPackages (
					new string[]{
						"com/confirmit/mobilesdk",
						"com/confirmit/mobilesdk/core",
						"com/confirmit/mobilesdk/core/exceptions",
						"com/confirmit/mobilesdk/core/framework",
						"com/confirmit/mobilesdk/core/framework/extmodules",
						"com/confirmit/mobilesdk/core/managers",
						"com/confirmit/mobilesdk/core/scheduler",
						"com/confirmit/mobilesdk/database/providers/room",
						"com/confirmit/mobilesdk/database/providers/room/dao",
						"com/confirmit/mobilesdk/database/providers/room/domain",
						"com/confirmit/mobilesdk/database/providers/room/model",
						"com/confirmit/mobilesdk/exts",
						"com/confirmit/mobilesdk/scripting/common",
						"com/confirmit/mobilesdk/scripting/surveyengine/common/exprobjs",
						"com/confirmit/mobilesdk/surveyengine",
						"com/confirmit/mobilesdk/surveyengine/data",
						"com/confirmit/mobilesdk/surveyengine/data/store",
						"com/confirmit/mobilesdk/surveyengine/managers",
						"com/confirmit/mobilesdk/surveyengine/packages",
						"com/confirmit/mobilesdk/surveyengine/packages/actions",
						"com/confirmit/mobilesdk/surveyengine/packages/question",
						"com/confirmit/mobilesdk/surveyengine/packages/question/constraints",
						"com/confirmit/mobilesdk/surveyengine/packages/question/domains",
						"com/confirmit/mobilesdk/surveyengine/runner",
						"com/confirmit/mobilesdk/surveyengine/runner/loop",
						"com/confirmit/mobilesdk/surveyengine/runner/stacks",
						"com/confirmit/mobilesdk/sync",
						"com/confirmit/mobilesdk/sync/domain",
						"com/confirmit/mobilesdk/sync/domain/infos",
						"com/confirmit/mobilesdk/sync/payloads",
						"com/confirmit/mobilesdk/sync/request",
						"com/confirmit/mobilesdk/sync/request/defaults",
						"com/confirmit/mobilesdk/sync/responsemodels",
						"com/confirmit/mobilesdk/trigger",
						"com/confirmit/mobilesdk/ui",
						"com/confirmit/mobilesdk/utils",
						"com/confirmit/mobilesdk/web",
					},
					new Converter<string, Type>[]{
						lookup_com_confirmit_mobilesdk_package,
						lookup_com_confirmit_mobilesdk_core_package,
						lookup_com_confirmit_mobilesdk_core_exceptions_package,
						lookup_com_confirmit_mobilesdk_core_framework_package,
						lookup_com_confirmit_mobilesdk_core_framework_extmodules_package,
						lookup_com_confirmit_mobilesdk_core_managers_package,
						lookup_com_confirmit_mobilesdk_core_scheduler_package,
						lookup_com_confirmit_mobilesdk_database_providers_room_package,
						lookup_com_confirmit_mobilesdk_database_providers_room_dao_package,
						lookup_com_confirmit_mobilesdk_database_providers_room_domain_package,
						lookup_com_confirmit_mobilesdk_database_providers_room_model_package,
						lookup_com_confirmit_mobilesdk_exts_package,
						lookup_com_confirmit_mobilesdk_scripting_common_package,
						lookup_com_confirmit_mobilesdk_scripting_surveyengine_common_exprobjs_package,
						lookup_com_confirmit_mobilesdk_surveyengine_package,
						lookup_com_confirmit_mobilesdk_surveyengine_data_package,
						lookup_com_confirmit_mobilesdk_surveyengine_data_store_package,
						lookup_com_confirmit_mobilesdk_surveyengine_managers_package,
						lookup_com_confirmit_mobilesdk_surveyengine_packages_package,
						lookup_com_confirmit_mobilesdk_surveyengine_packages_actions_package,
						lookup_com_confirmit_mobilesdk_surveyengine_packages_question_package,
						lookup_com_confirmit_mobilesdk_surveyengine_packages_question_constraints_package,
						lookup_com_confirmit_mobilesdk_surveyengine_packages_question_domains_package,
						lookup_com_confirmit_mobilesdk_surveyengine_runner_package,
						lookup_com_confirmit_mobilesdk_surveyengine_runner_loop_package,
						lookup_com_confirmit_mobilesdk_surveyengine_runner_stacks_package,
						lookup_com_confirmit_mobilesdk_sync_package,
						lookup_com_confirmit_mobilesdk_sync_domain_package,
						lookup_com_confirmit_mobilesdk_sync_domain_infos_package,
						lookup_com_confirmit_mobilesdk_sync_payloads_package,
						lookup_com_confirmit_mobilesdk_sync_request_package,
						lookup_com_confirmit_mobilesdk_sync_request_defaults_package,
						lookup_com_confirmit_mobilesdk_sync_responsemodels_package,
						lookup_com_confirmit_mobilesdk_trigger_package,
						lookup_com_confirmit_mobilesdk_ui_package,
						lookup_com_confirmit_mobilesdk_utils_package,
						lookup_com_confirmit_mobilesdk_web_package,
					});
#if MONODROID_TIMING
			var end = DateTime.Now;
			Android.Util.Log.Info ("MonoDroid-Timing", "RegisterPackages time: " + (end - new DateTime (1970, 1, 1)).TotalMilliseconds + " [elapsed: " + (end - start).TotalMilliseconds + " ms]");
#endif // def MONODROID_TIMING
		}

#if NET5_0_OR_GREATER
		[System.Diagnostics.CodeAnalysis.UnconditionalSuppressMessage ("Trimming", "IL2057")]
#endif
		static Type Lookup (string[] mappings, string javaType)
		{
			var managedType = Java.Interop.TypeManager.LookupTypeMapping (mappings, javaType);
			if (managedType == null)
				return null;
			return Type.GetType (managedType);
		}

		static string[] package_com_confirmit_mobilesdk_mappings;
		static Type lookup_com_confirmit_mobilesdk_package (string klass)
		{
			if (package_com_confirmit_mobilesdk_mappings == null) {
				package_com_confirmit_mobilesdk_mappings = new string[]{
					"com/confirmit/mobilesdk/a:Com.Confirmit.Mobilesdk.RootA",
					"com/confirmit/mobilesdk/b:Com.Confirmit.Mobilesdk.RootB",
				};
			}

			return Lookup (package_com_confirmit_mobilesdk_mappings, klass);
		}

		static string[] package_com_confirmit_mobilesdk_core_mappings;
		static Type lookup_com_confirmit_mobilesdk_core_package (string klass)
		{
			if (package_com_confirmit_mobilesdk_core_mappings == null) {
				package_com_confirmit_mobilesdk_core_mappings = new string[]{
					"com/confirmit/mobilesdk/core/a:Com.Confirmit.Mobilesdk.Core.CoreA",
					"com/confirmit/mobilesdk/core/b:Com.Confirmit.Mobilesdk.Core.CoreB",
					"com/confirmit/mobilesdk/core/c:Com.Confirmit.Mobilesdk.Core.CoreC",
					"com/confirmit/mobilesdk/core/d:Com.Confirmit.Mobilesdk.Core.CoreD",
					"com/confirmit/mobilesdk/core/e:Com.Confirmit.Mobilesdk.Core.CoreE",
					"com/confirmit/mobilesdk/core/f:Com.Confirmit.Mobilesdk.Core.CoreF",
					"com/confirmit/mobilesdk/core/g:Com.Confirmit.Mobilesdk.Core.CoreG",
					"com/confirmit/mobilesdk/core/h:Com.Confirmit.Mobilesdk.Core.CoreH",
					"com/confirmit/mobilesdk/core/i:Com.Confirmit.Mobilesdk.Core.CoreI",
				};
			}

			return Lookup (package_com_confirmit_mobilesdk_core_mappings, klass);
		}

		static string[] package_com_confirmit_mobilesdk_core_exceptions_mappings;
		static Type lookup_com_confirmit_mobilesdk_core_exceptions_package (string klass)
		{
			if (package_com_confirmit_mobilesdk_core_exceptions_mappings == null) {
				package_com_confirmit_mobilesdk_core_exceptions_mappings = new string[]{
					"com/confirmit/mobilesdk/core/exceptions/a:Com.Confirmit.Mobilesdk.Core.Exceptions.CoreExceptionsA",
					"com/confirmit/mobilesdk/core/exceptions/b:Com.Confirmit.Mobilesdk.Core.Exceptions.CoreExceptionsB",
					"com/confirmit/mobilesdk/core/exceptions/c:Com.Confirmit.Mobilesdk.Core.Exceptions.CoreExceptionsC",
				};
			}

			return Lookup (package_com_confirmit_mobilesdk_core_exceptions_mappings, klass);
		}

		static string[] package_com_confirmit_mobilesdk_core_framework_mappings;
		static Type lookup_com_confirmit_mobilesdk_core_framework_package (string klass)
		{
			if (package_com_confirmit_mobilesdk_core_framework_mappings == null) {
				package_com_confirmit_mobilesdk_core_framework_mappings = new string[]{
					"com/confirmit/mobilesdk/core/framework/a:Com.Confirmit.Mobilesdk.Core.Framework.CoreFrameworkA",
					"com/confirmit/mobilesdk/core/framework/b:Com.Confirmit.Mobilesdk.Core.Framework.CoreFrameworkB",
				};
			}

			return Lookup (package_com_confirmit_mobilesdk_core_framework_mappings, klass);
		}

		static string[] package_com_confirmit_mobilesdk_core_framework_extmodules_mappings;
		static Type lookup_com_confirmit_mobilesdk_core_framework_extmodules_package (string klass)
		{
			if (package_com_confirmit_mobilesdk_core_framework_extmodules_mappings == null) {
				package_com_confirmit_mobilesdk_core_framework_extmodules_mappings = new string[]{
					"com/confirmit/mobilesdk/core/framework/extmodules/a:Com.Confirmit.Mobilesdk.Core.Framework.Extmodules.CoreFrameworkExtModulesA",
					"com/confirmit/mobilesdk/core/framework/extmodules/b:Com.Confirmit.Mobilesdk.Core.Framework.Extmodules.CoreFrameworkExtModulesB",
				};
			}

			return Lookup (package_com_confirmit_mobilesdk_core_framework_extmodules_mappings, klass);
		}

		static string[] package_com_confirmit_mobilesdk_core_managers_mappings;
		static Type lookup_com_confirmit_mobilesdk_core_managers_package (string klass)
		{
			if (package_com_confirmit_mobilesdk_core_managers_mappings == null) {
				package_com_confirmit_mobilesdk_core_managers_mappings = new string[]{
					"com/confirmit/mobilesdk/core/managers/a:Com.Confirmit.Mobilesdk.Core.Managers.CoreManagersA",
					"com/confirmit/mobilesdk/core/managers/b:Com.Confirmit.Mobilesdk.Core.Managers.CoreManagersB",
				};
			}

			return Lookup (package_com_confirmit_mobilesdk_core_managers_mappings, klass);
		}

		static string[] package_com_confirmit_mobilesdk_core_scheduler_mappings;
		static Type lookup_com_confirmit_mobilesdk_core_scheduler_package (string klass)
		{
			if (package_com_confirmit_mobilesdk_core_scheduler_mappings == null) {
				package_com_confirmit_mobilesdk_core_scheduler_mappings = new string[]{
					"com/confirmit/mobilesdk/core/scheduler/a:Com.Confirmit.Mobilesdk.Core.Scheduler.CoreSchedulerA",
					"com/confirmit/mobilesdk/core/scheduler/c:Com.Confirmit.Mobilesdk.Core.Scheduler.CoreSchedulerC",
					"com/confirmit/mobilesdk/core/scheduler/d:Com.Confirmit.Mobilesdk.Core.Scheduler.CoreSchedulerD",
				};
			}

			return Lookup (package_com_confirmit_mobilesdk_core_scheduler_mappings, klass);
		}

		static string[] package_com_confirmit_mobilesdk_database_providers_room_mappings;
		static Type lookup_com_confirmit_mobilesdk_database_providers_room_package (string klass)
		{
			if (package_com_confirmit_mobilesdk_database_providers_room_mappings == null) {
				package_com_confirmit_mobilesdk_database_providers_room_mappings = new string[]{
					"com/confirmit/mobilesdk/database/providers/room/a:Com.Confirmit.Mobilesdk.Database.Providers.Room.ProvidersRoomA",
					"com/confirmit/mobilesdk/database/providers/room/b:Com.Confirmit.Mobilesdk.Database.Providers.Room.ProvidersRoomB",
				};
			}

			return Lookup (package_com_confirmit_mobilesdk_database_providers_room_mappings, klass);
		}

		static string[] package_com_confirmit_mobilesdk_database_providers_room_dao_mappings;
		static Type lookup_com_confirmit_mobilesdk_database_providers_room_dao_package (string klass)
		{
			if (package_com_confirmit_mobilesdk_database_providers_room_dao_mappings == null) {
				package_com_confirmit_mobilesdk_database_providers_room_dao_mappings = new string[]{
					"com/confirmit/mobilesdk/database/providers/room/dao/a:Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.DaoCustomDataA",
					"com/confirmit/mobilesdk/database/providers/room/dao/b:Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.DaoPrefsB",
					"com/confirmit/mobilesdk/database/providers/room/dao/c:Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.DaoProgramsC",
					"com/confirmit/mobilesdk/database/providers/room/dao/d:Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.DaoProgramPrefD",
					"com/confirmit/mobilesdk/database/providers/room/dao/e:Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.DaoRespondentsE",
					"com/confirmit/mobilesdk/database/providers/room/dao/f:Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.DaoRespondentValuesF",
					"com/confirmit/mobilesdk/database/providers/room/dao/g:Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.DaoResponseControlsG",
					"com/confirmit/mobilesdk/database/providers/room/dao/h:Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.DaoResponsesH",
					"com/confirmit/mobilesdk/database/providers/room/dao/i:Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.DaoScenarioCounterI",
					"com/confirmit/mobilesdk/database/providers/room/dao/j:Com.Confirmit.Mobilesdk.Database.Providers.Room.Dao.DaoScenarioJ",
				};
			}

			return Lookup (package_com_confirmit_mobilesdk_database_providers_room_dao_mappings, klass);
		}

		static string[] package_com_confirmit_mobilesdk_database_providers_room_domain_mappings;
		static Type lookup_com_confirmit_mobilesdk_database_providers_room_domain_package (string klass)
		{
			if (package_com_confirmit_mobilesdk_database_providers_room_domain_mappings == null) {
				package_com_confirmit_mobilesdk_database_providers_room_domain_mappings = new string[]{
					"com/confirmit/mobilesdk/database/providers/room/domain/a:Com.Confirmit.Mobilesdk.Database.Providers.Room.Domain.ProvidersRoomDomainA",
					"com/confirmit/mobilesdk/database/providers/room/domain/b:Com.Confirmit.Mobilesdk.Database.Providers.Room.Domain.ProvidersRoomDomainB",
					"com/confirmit/mobilesdk/database/providers/room/domain/c:Com.Confirmit.Mobilesdk.Database.Providers.Room.Domain.ProvidersRoomDomainC",
					"com/confirmit/mobilesdk/database/providers/room/domain/d:Com.Confirmit.Mobilesdk.Database.Providers.Room.Domain.ProvidersRoomDomainD",
					"com/confirmit/mobilesdk/database/providers/room/domain/e:Com.Confirmit.Mobilesdk.Database.Providers.Room.Domain.ProvidersRoomDomainE",
					"com/confirmit/mobilesdk/database/providers/room/domain/f:Com.Confirmit.Mobilesdk.Database.Providers.Room.Domain.ProvidersRoomDomainF",
					"com/confirmit/mobilesdk/database/providers/room/domain/g:Com.Confirmit.Mobilesdk.Database.Providers.Room.Domain.ProvidersRoomDomainG",
					"com/confirmit/mobilesdk/database/providers/room/domain/h:Com.Confirmit.Mobilesdk.Database.Providers.Room.Domain.ProvidersRoomDomainH",
					"com/confirmit/mobilesdk/database/providers/room/domain/i:Com.Confirmit.Mobilesdk.Database.Providers.Room.Domain.ProvidersRoomDomainI",
					"com/confirmit/mobilesdk/database/providers/room/domain/j:Com.Confirmit.Mobilesdk.Database.Providers.Room.Domain.ProvidersRoomDomainJ",
					"com/confirmit/mobilesdk/database/providers/room/domain/k:Com.Confirmit.Mobilesdk.Database.Providers.Room.Domain.ProvidersRoomDomainK",
					"com/confirmit/mobilesdk/database/providers/room/domain/l:Com.Confirmit.Mobilesdk.Database.Providers.Room.Domain.ProvidersRoomDomainL",
					"com/confirmit/mobilesdk/database/providers/room/domain/m:Com.Confirmit.Mobilesdk.Database.Providers.Room.Domain.ProvidersRoomDomainM",
				};
			}

			return Lookup (package_com_confirmit_mobilesdk_database_providers_room_domain_mappings, klass);
		}

		static string[] package_com_confirmit_mobilesdk_database_providers_room_model_mappings;
		static Type lookup_com_confirmit_mobilesdk_database_providers_room_model_package (string klass)
		{
			if (package_com_confirmit_mobilesdk_database_providers_room_model_mappings == null) {
				package_com_confirmit_mobilesdk_database_providers_room_model_mappings = new string[]{
					"com/confirmit/mobilesdk/database/providers/room/model/a:Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.CustomData",
					"com/confirmit/mobilesdk/database/providers/room/model/b:Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Prefs",
					"com/confirmit/mobilesdk/database/providers/room/model/c:Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Programs",
					"com/confirmit/mobilesdk/database/providers/room/model/d:Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.ProgramPref",
					"com/confirmit/mobilesdk/database/providers/room/model/e:Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Respondents",
					"com/confirmit/mobilesdk/database/providers/room/model/f:Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.RespondentValues",
					"com/confirmit/mobilesdk/database/providers/room/model/g:Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.ResponseControls",
					"com/confirmit/mobilesdk/database/providers/room/model/h:Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Responses",
					"com/confirmit/mobilesdk/database/providers/room/model/i:Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.ScenarioCounter",
					"com/confirmit/mobilesdk/database/providers/room/model/j:Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Scenario",
					"com/confirmit/mobilesdk/database/providers/room/model/k:Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Servers",
					"com/confirmit/mobilesdk/database/providers/room/model/l:Com.Confirmit.Mobilesdk.Database.Providers.Room.Model.Surveys",
				};
			}

			return Lookup (package_com_confirmit_mobilesdk_database_providers_room_model_mappings, klass);
		}

		static string[] package_com_confirmit_mobilesdk_exts_mappings;
		static Type lookup_com_confirmit_mobilesdk_exts_package (string klass)
		{
			if (package_com_confirmit_mobilesdk_exts_mappings == null) {
				package_com_confirmit_mobilesdk_exts_mappings = new string[]{
					"com/confirmit/mobilesdk/exts/a:Com.Confirmit.Mobilesdk.Exts.ExtsA",
					"com/confirmit/mobilesdk/exts/b:Com.Confirmit.Mobilesdk.Exts.ExtsB",
					"com/confirmit/mobilesdk/exts/c:Com.Confirmit.Mobilesdk.Exts.ExtsC",
					"com/confirmit/mobilesdk/exts/d:Com.Confirmit.Mobilesdk.Exts.ExtsD",
					"com/confirmit/mobilesdk/exts/e:Com.Confirmit.Mobilesdk.Exts.ExtsE",
				};
			}

			return Lookup (package_com_confirmit_mobilesdk_exts_mappings, klass);
		}

		static string[] package_com_confirmit_mobilesdk_scripting_common_mappings;
		static Type lookup_com_confirmit_mobilesdk_scripting_common_package (string klass)
		{
			if (package_com_confirmit_mobilesdk_scripting_common_mappings == null) {
				package_com_confirmit_mobilesdk_scripting_common_mappings = new string[]{
					"com/confirmit/mobilesdk/scripting/common/a:Com.Confirmit.Mobilesdk.Scripting.Common.ScriptingCommonA",
					"com/confirmit/mobilesdk/scripting/common/b:Com.Confirmit.Mobilesdk.Scripting.Common.ScriptingCommonB",
				};
			}

			return Lookup (package_com_confirmit_mobilesdk_scripting_common_mappings, klass);
		}

		static string[] package_com_confirmit_mobilesdk_scripting_surveyengine_common_exprobjs_mappings;
		static Type lookup_com_confirmit_mobilesdk_scripting_surveyengine_common_exprobjs_package (string klass)
		{
			if (package_com_confirmit_mobilesdk_scripting_surveyengine_common_exprobjs_mappings == null) {
				package_com_confirmit_mobilesdk_scripting_surveyengine_common_exprobjs_mappings = new string[]{
					"com/confirmit/mobilesdk/scripting/surveyengine/common/exprobjs/a:Com.Confirmit.Mobilesdk.Scripting.Surveyengine.Common.Exprobjs.CommonExprobA",
					"com/confirmit/mobilesdk/scripting/surveyengine/common/exprobjs/b:Com.Confirmit.Mobilesdk.Scripting.Surveyengine.Common.Exprobjs.CommonExprobB",
					"com/confirmit/mobilesdk/scripting/surveyengine/common/exprobjs/c:Com.Confirmit.Mobilesdk.Scripting.Surveyengine.Common.Exprobjs.CommonExprobC",
					"com/confirmit/mobilesdk/scripting/surveyengine/common/exprobjs/d:Com.Confirmit.Mobilesdk.Scripting.Surveyengine.Common.Exprobjs.CommonExprobD",
					"com/confirmit/mobilesdk/scripting/surveyengine/common/exprobjs/e:Com.Confirmit.Mobilesdk.Scripting.Surveyengine.Common.Exprobjs.CommonExprobE",
					"com/confirmit/mobilesdk/scripting/surveyengine/common/exprobjs/f:Com.Confirmit.Mobilesdk.Scripting.Surveyengine.Common.Exprobjs.CommonExprobF",
				};
			}

			return Lookup (package_com_confirmit_mobilesdk_scripting_surveyengine_common_exprobjs_mappings, klass);
		}

		static string[] package_com_confirmit_mobilesdk_surveyengine_mappings;
		static Type lookup_com_confirmit_mobilesdk_surveyengine_package (string klass)
		{
			if (package_com_confirmit_mobilesdk_surveyengine_mappings == null) {
				package_com_confirmit_mobilesdk_surveyengine_mappings = new string[]{
					"com/confirmit/mobilesdk/surveyengine/a:Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineA",
					"com/confirmit/mobilesdk/surveyengine/a0:Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineAO",
					"com/confirmit/mobilesdk/surveyengine/b:Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineB",
					"com/confirmit/mobilesdk/surveyengine/c:Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineC",
					"com/confirmit/mobilesdk/surveyengine/d:Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineD",
					"com/confirmit/mobilesdk/surveyengine/e:Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineE",
					"com/confirmit/mobilesdk/surveyengine/f:Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineF",
					"com/confirmit/mobilesdk/surveyengine/g:Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineG",
					"com/confirmit/mobilesdk/surveyengine/h:Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineH",
					"com/confirmit/mobilesdk/surveyengine/i:Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineI",
					"com/confirmit/mobilesdk/surveyengine/j:Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineJ",
					"com/confirmit/mobilesdk/surveyengine/k:Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineK",
					"com/confirmit/mobilesdk/surveyengine/l:Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineL",
					"com/confirmit/mobilesdk/surveyengine/m:Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineM",
					"com/confirmit/mobilesdk/surveyengine/n:Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineN",
					"com/confirmit/mobilesdk/surveyengine/o:Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineO",
					"com/confirmit/mobilesdk/surveyengine/p:Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineP",
					"com/confirmit/mobilesdk/surveyengine/q:Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineQ",
					"com/confirmit/mobilesdk/surveyengine/r:Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineR",
					"com/confirmit/mobilesdk/surveyengine/s:Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineS",
					"com/confirmit/mobilesdk/surveyengine/t:Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineT",
					"com/confirmit/mobilesdk/surveyengine/u:Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineU",
					"com/confirmit/mobilesdk/surveyengine/v:Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineV",
					"com/confirmit/mobilesdk/surveyengine/w:Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineW",
					"com/confirmit/mobilesdk/surveyengine/x:Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineX",
					"com/confirmit/mobilesdk/surveyengine/y:Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineY",
					"com/confirmit/mobilesdk/surveyengine/z:Com.Confirmit.Mobilesdk.Surveyengine.SurveyengineZ",
				};
			}

			return Lookup (package_com_confirmit_mobilesdk_surveyengine_mappings, klass);
		}

		static string[] package_com_confirmit_mobilesdk_surveyengine_data_mappings;
		static Type lookup_com_confirmit_mobilesdk_surveyengine_data_package (string klass)
		{
			if (package_com_confirmit_mobilesdk_surveyengine_data_mappings == null) {
				package_com_confirmit_mobilesdk_surveyengine_data_mappings = new string[]{
					"com/confirmit/mobilesdk/surveyengine/data/a:Com.Confirmit.Mobilesdk.Surveyengine.Data.SurveyEngineDataA",
					"com/confirmit/mobilesdk/surveyengine/data/b:Com.Confirmit.Mobilesdk.Surveyengine.Data.SurveyEngineDataB",
				};
			}

			return Lookup (package_com_confirmit_mobilesdk_surveyengine_data_mappings, klass);
		}

		static string[] package_com_confirmit_mobilesdk_surveyengine_data_store_mappings;
		static Type lookup_com_confirmit_mobilesdk_surveyengine_data_store_package (string klass)
		{
			if (package_com_confirmit_mobilesdk_surveyengine_data_store_mappings == null) {
				package_com_confirmit_mobilesdk_surveyengine_data_store_mappings = new string[]{
					"com/confirmit/mobilesdk/surveyengine/data/store/a:Com.Confirmit.Mobilesdk.Surveyengine.Data.Store.SurveyEngineDataStoreA",
				};
			}

			return Lookup (package_com_confirmit_mobilesdk_surveyengine_data_store_mappings, klass);
		}

		static string[] package_com_confirmit_mobilesdk_surveyengine_managers_mappings;
		static Type lookup_com_confirmit_mobilesdk_surveyengine_managers_package (string klass)
		{
			if (package_com_confirmit_mobilesdk_surveyengine_managers_mappings == null) {
				package_com_confirmit_mobilesdk_surveyengine_managers_mappings = new string[]{
					"com/confirmit/mobilesdk/surveyengine/managers/a:Com.Confirmit.Mobilesdk.Surveyengine.Managers.SurveyEngineManagersA",
					"com/confirmit/mobilesdk/surveyengine/managers/b:Com.Confirmit.Mobilesdk.Surveyengine.Managers.SurveyEngineManagersB",
					"com/confirmit/mobilesdk/surveyengine/managers/c:Com.Confirmit.Mobilesdk.Surveyengine.Managers.SurveyEngineManagersC",
					"com/confirmit/mobilesdk/surveyengine/managers/d:Com.Confirmit.Mobilesdk.Surveyengine.Managers.SurveyEngineManagersD",
					"com/confirmit/mobilesdk/surveyengine/managers/e:Com.Confirmit.Mobilesdk.Surveyengine.Managers.SurveyEngineManagersE",
					"com/confirmit/mobilesdk/surveyengine/managers/f:Com.Confirmit.Mobilesdk.Surveyengine.Managers.SurveyEngineManagersF",
					"com/confirmit/mobilesdk/surveyengine/managers/g:Com.Confirmit.Mobilesdk.Surveyengine.Managers.SurveyEngineManagersG",
					"com/confirmit/mobilesdk/surveyengine/managers/h:Com.Confirmit.Mobilesdk.Surveyengine.Managers.SurveyEngineManagersH",
					"com/confirmit/mobilesdk/surveyengine/managers/i:Com.Confirmit.Mobilesdk.Surveyengine.Managers.SurveyEngineManagersI",
					"com/confirmit/mobilesdk/surveyengine/managers/j:Com.Confirmit.Mobilesdk.Surveyengine.Managers.SurveyEngineManagersJ",
					"com/confirmit/mobilesdk/surveyengine/managers/k:Com.Confirmit.Mobilesdk.Surveyengine.Managers.SurveyEngineManagersK",
					"com/confirmit/mobilesdk/surveyengine/managers/l:Com.Confirmit.Mobilesdk.Surveyengine.Managers.SurveyEngineManagersL",
					"com/confirmit/mobilesdk/surveyengine/managers/m:Com.Confirmit.Mobilesdk.Surveyengine.Managers.SurveyEngineManagersM",
					"com/confirmit/mobilesdk/surveyengine/managers/n:Com.Confirmit.Mobilesdk.Surveyengine.Managers.SurveyEngineManagersN",
					"com/confirmit/mobilesdk/surveyengine/managers/o:Com.Confirmit.Mobilesdk.Surveyengine.Managers.SurveyEngineManagersO",
					"com/confirmit/mobilesdk/surveyengine/managers/p:Com.Confirmit.Mobilesdk.Surveyengine.Managers.SurveyEngineManagersP",
					"com/confirmit/mobilesdk/surveyengine/managers/q:Com.Confirmit.Mobilesdk.Surveyengine.Managers.SurveyEngineManagersQ",
				};
			}

			return Lookup (package_com_confirmit_mobilesdk_surveyengine_managers_mappings, klass);
		}

		static string[] package_com_confirmit_mobilesdk_surveyengine_packages_mappings;
		static Type lookup_com_confirmit_mobilesdk_surveyengine_packages_package (string klass)
		{
			if (package_com_confirmit_mobilesdk_surveyengine_packages_mappings == null) {
				package_com_confirmit_mobilesdk_surveyengine_packages_mappings = new string[]{
					"com/confirmit/mobilesdk/surveyengine/packages/a:Com.Confirmit.Mobilesdk.Surveyengine.Packages.SurveyEnginePackagesA",
					"com/confirmit/mobilesdk/surveyengine/packages/b:Com.Confirmit.Mobilesdk.Surveyengine.Packages.SurveyEnginePackagesB",
					"com/confirmit/mobilesdk/surveyengine/packages/c:Com.Confirmit.Mobilesdk.Surveyengine.Packages.SurveyEnginePackagesC",
					"com/confirmit/mobilesdk/surveyengine/packages/d:Com.Confirmit.Mobilesdk.Surveyengine.Packages.SurveyEnginePackagesD",
					"com/confirmit/mobilesdk/surveyengine/packages/e:Com.Confirmit.Mobilesdk.Surveyengine.Packages.SurveyEnginePackagesE",
					"com/confirmit/mobilesdk/surveyengine/packages/f:Com.Confirmit.Mobilesdk.Surveyengine.Packages.SurveyEnginePackagesF",
					"com/confirmit/mobilesdk/surveyengine/packages/g:Com.Confirmit.Mobilesdk.Surveyengine.Packages.SurveyEnginePackagesG",
				};
			}

			return Lookup (package_com_confirmit_mobilesdk_surveyengine_packages_mappings, klass);
		}

		static string[] package_com_confirmit_mobilesdk_surveyengine_packages_actions_mappings;
		static Type lookup_com_confirmit_mobilesdk_surveyengine_packages_actions_package (string klass)
		{
			if (package_com_confirmit_mobilesdk_surveyengine_packages_actions_mappings == null) {
				package_com_confirmit_mobilesdk_surveyengine_packages_actions_mappings = new string[]{
					"com/confirmit/mobilesdk/surveyengine/packages/actions/a:Com.Confirmit.Mobilesdk.Surveyengine.Packages.Actions.SurveyEnginePackagesActionsA",
					"com/confirmit/mobilesdk/surveyengine/packages/actions/b:Com.Confirmit.Mobilesdk.Surveyengine.Packages.Actions.SurveyEnginePackagesActionsB",
					"com/confirmit/mobilesdk/surveyengine/packages/actions/c:Com.Confirmit.Mobilesdk.Surveyengine.Packages.Actions.SurveyEnginePackagesActionsC",
					"com/confirmit/mobilesdk/surveyengine/packages/actions/d:Com.Confirmit.Mobilesdk.Surveyengine.Packages.Actions.SurveyEnginePackagesActionsD",
					"com/confirmit/mobilesdk/surveyengine/packages/actions/e:Com.Confirmit.Mobilesdk.Surveyengine.Packages.Actions.SurveyEnginePackagesActionsE",
					"com/confirmit/mobilesdk/surveyengine/packages/actions/f:Com.Confirmit.Mobilesdk.Surveyengine.Packages.Actions.SurveyEnginePackagesActionsF",
					"com/confirmit/mobilesdk/surveyengine/packages/actions/g:Com.Confirmit.Mobilesdk.Surveyengine.Packages.Actions.SurveyEnginePackagesActionsG",
					"com/confirmit/mobilesdk/surveyengine/packages/actions/h:Com.Confirmit.Mobilesdk.Surveyengine.Packages.Actions.SurveyEnginePackagesActionsH",
					"com/confirmit/mobilesdk/surveyengine/packages/actions/i:Com.Confirmit.Mobilesdk.Surveyengine.Packages.Actions.SurveyEnginePackagesActionsI",
					"com/confirmit/mobilesdk/surveyengine/packages/actions/j:Com.Confirmit.Mobilesdk.Surveyengine.Packages.Actions.SurveyEnginePackagesActionsJ",
					"com/confirmit/mobilesdk/surveyengine/packages/actions/k:Com.Confirmit.Mobilesdk.Surveyengine.Packages.Actions.SurveyEnginePackagesActionsK",
					"com/confirmit/mobilesdk/surveyengine/packages/actions/l:Com.Confirmit.Mobilesdk.Surveyengine.Packages.Actions.SurveyEnginePackagesActionsL",
					"com/confirmit/mobilesdk/surveyengine/packages/actions/m:Com.Confirmit.Mobilesdk.Surveyengine.Packages.Actions.SurveyEnginePackagesActionsM",
					"com/confirmit/mobilesdk/surveyengine/packages/actions/n:Com.Confirmit.Mobilesdk.Surveyengine.Packages.Actions.SurveyEnginePackagesActionsN",
					"com/confirmit/mobilesdk/surveyengine/packages/actions/o:Com.Confirmit.Mobilesdk.Surveyengine.Packages.Actions.SurveyEnginePackagesActionsO",
					"com/confirmit/mobilesdk/surveyengine/packages/actions/p:Com.Confirmit.Mobilesdk.Surveyengine.Packages.Actions.SurveyEnginePackagesActionsP",
					"com/confirmit/mobilesdk/surveyengine/packages/actions/q:Com.Confirmit.Mobilesdk.Surveyengine.Packages.Actions.SurveyEnginePackagesActionsQ",
					"com/confirmit/mobilesdk/surveyengine/packages/actions/r:Com.Confirmit.Mobilesdk.Surveyengine.Packages.Actions.SurveyEnginePackagesActionsR",
					"com/confirmit/mobilesdk/surveyengine/packages/actions/s:Com.Confirmit.Mobilesdk.Surveyengine.Packages.Actions.SurveyEnginePackagesActionsS",
					"com/confirmit/mobilesdk/surveyengine/packages/actions/t:Com.Confirmit.Mobilesdk.Surveyengine.Packages.Actions.SurveyEnginePackagesActionsT",
				};
			}

			return Lookup (package_com_confirmit_mobilesdk_surveyengine_packages_actions_mappings, klass);
		}

		static string[] package_com_confirmit_mobilesdk_surveyengine_packages_question_mappings;
		static Type lookup_com_confirmit_mobilesdk_surveyengine_packages_question_package (string klass)
		{
			if (package_com_confirmit_mobilesdk_surveyengine_packages_question_mappings == null) {
				package_com_confirmit_mobilesdk_surveyengine_packages_question_mappings = new string[]{
					"com/confirmit/mobilesdk/surveyengine/packages/question/a:Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.SurveyEnginePackagesQuestionA",
					"com/confirmit/mobilesdk/surveyengine/packages/question/b:Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.SurveyEnginePackagesQuestionB",
					"com/confirmit/mobilesdk/surveyengine/packages/question/c:Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.SurveyEnginePackagesQuestionC",
					"com/confirmit/mobilesdk/surveyengine/packages/question/d:Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.SurveyEnginePackagesQuestionD",
					"com/confirmit/mobilesdk/surveyengine/packages/question/e:Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.SurveyEnginePackagesQuestionE",
					"com/confirmit/mobilesdk/surveyengine/packages/question/f:Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.SurveyEnginePackagesQuestionF",
					"com/confirmit/mobilesdk/surveyengine/packages/question/g:Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.SurveyEnginePackagesQuestionG",
					"com/confirmit/mobilesdk/surveyengine/packages/question/h:Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.SurveyEnginePackagesQuestionH",
					"com/confirmit/mobilesdk/surveyengine/packages/question/i:Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.SurveyEnginePackagesQuestionI",
					"com/confirmit/mobilesdk/surveyengine/packages/question/j:Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.SurveyEnginePackagesQuestionJ",
					"com/confirmit/mobilesdk/surveyengine/packages/question/k:Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.SurveyEnginePackagesQuestionK",
					"com/confirmit/mobilesdk/surveyengine/packages/question/l:Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.SurveyEnginePackagesQuestionL",
					"com/confirmit/mobilesdk/surveyengine/packages/question/m:Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.SurveyEnginePackagesQuestionM",
					"com/confirmit/mobilesdk/surveyengine/packages/question/n:Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.SurveyEnginePackagesQuestionN",
					"com/confirmit/mobilesdk/surveyengine/packages/question/o:Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.SurveyEnginePackagesQuestionO",
				};
			}

			return Lookup (package_com_confirmit_mobilesdk_surveyengine_packages_question_mappings, klass);
		}

		static string[] package_com_confirmit_mobilesdk_surveyengine_packages_question_constraints_mappings;
		static Type lookup_com_confirmit_mobilesdk_surveyengine_packages_question_constraints_package (string klass)
		{
			if (package_com_confirmit_mobilesdk_surveyengine_packages_question_constraints_mappings == null) {
				package_com_confirmit_mobilesdk_surveyengine_packages_question_constraints_mappings = new string[]{
					"com/confirmit/mobilesdk/surveyengine/packages/question/constraints/a:Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.Constraints.SurveyEnginePackagesQuestionConstraintsA",
					"com/confirmit/mobilesdk/surveyengine/packages/question/constraints/b:Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.Constraints.SurveyEnginePackagesQuestionConstraintsB",
					"com/confirmit/mobilesdk/surveyengine/packages/question/constraints/c:Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.Constraints.SurveyEnginePackagesQuestionConstraintsC",
					"com/confirmit/mobilesdk/surveyengine/packages/question/constraints/d:Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.Constraints.SurveyEnginePackagesQuestionConstraintsD",
					"com/confirmit/mobilesdk/surveyengine/packages/question/constraints/e:Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.Constraints.SurveyEnginePackagesQuestionConstraintsE",
					"com/confirmit/mobilesdk/surveyengine/packages/question/constraints/f:Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.Constraints.SurveyEnginePackagesQuestionConstraintsF",
					"com/confirmit/mobilesdk/surveyengine/packages/question/constraints/g:Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.Constraints.SurveyEnginePackagesQuestionConstraintsG",
				};
			}

			return Lookup (package_com_confirmit_mobilesdk_surveyengine_packages_question_constraints_mappings, klass);
		}

		static string[] package_com_confirmit_mobilesdk_surveyengine_packages_question_domains_mappings;
		static Type lookup_com_confirmit_mobilesdk_surveyengine_packages_question_domains_package (string klass)
		{
			if (package_com_confirmit_mobilesdk_surveyengine_packages_question_domains_mappings == null) {
				package_com_confirmit_mobilesdk_surveyengine_packages_question_domains_mappings = new string[]{
					"com/confirmit/mobilesdk/surveyengine/packages/question/domains/a:Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.Domains.SurveyEnginePackagesQuestionDomainsA",
					"com/confirmit/mobilesdk/surveyengine/packages/question/domains/b:Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.Domains.SurveyEnginePackagesQuestionDomainsB",
					"com/confirmit/mobilesdk/surveyengine/packages/question/domains/c:Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.Domains.SurveyEnginePackagesQuestionDomainsC",
					"com/confirmit/mobilesdk/surveyengine/packages/question/domains/d:Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.Domains.SurveyEnginePackagesQuestionDomainsD",
					"com/confirmit/mobilesdk/surveyengine/packages/question/domains/e:Com.Confirmit.Mobilesdk.Surveyengine.Packages.Question.Domains.SurveyEnginePackagesQuestionDomainsE",
				};
			}

			return Lookup (package_com_confirmit_mobilesdk_surveyengine_packages_question_domains_mappings, klass);
		}

		static string[] package_com_confirmit_mobilesdk_surveyengine_runner_mappings;
		static Type lookup_com_confirmit_mobilesdk_surveyengine_runner_package (string klass)
		{
			if (package_com_confirmit_mobilesdk_surveyengine_runner_mappings == null) {
				package_com_confirmit_mobilesdk_surveyengine_runner_mappings = new string[]{
					"com/confirmit/mobilesdk/surveyengine/runner/a:Com.Confirmit.Mobilesdk.Surveyengine.Runner.SurveyEngineRunnerA",
					"com/confirmit/mobilesdk/surveyengine/runner/b:Com.Confirmit.Mobilesdk.Surveyengine.Runner.SurveyEngineRunnerB",
				};
			}

			return Lookup (package_com_confirmit_mobilesdk_surveyengine_runner_mappings, klass);
		}

		static string[] package_com_confirmit_mobilesdk_surveyengine_runner_loop_mappings;
		static Type lookup_com_confirmit_mobilesdk_surveyengine_runner_loop_package (string klass)
		{
			if (package_com_confirmit_mobilesdk_surveyengine_runner_loop_mappings == null) {
				package_com_confirmit_mobilesdk_surveyengine_runner_loop_mappings = new string[]{
					"com/confirmit/mobilesdk/surveyengine/runner/loop/a:Com.Confirmit.Mobilesdk.Surveyengine.Runner.Loop.SurveyEngineRunnerLoopA",
					"com/confirmit/mobilesdk/surveyengine/runner/loop/b:Com.Confirmit.Mobilesdk.Surveyengine.Runner.Loop.SurveyEngineRunnerLoopB",
				};
			}

			return Lookup (package_com_confirmit_mobilesdk_surveyengine_runner_loop_mappings, klass);
		}

		static string[] package_com_confirmit_mobilesdk_surveyengine_runner_stacks_mappings;
		static Type lookup_com_confirmit_mobilesdk_surveyengine_runner_stacks_package (string klass)
		{
			if (package_com_confirmit_mobilesdk_surveyengine_runner_stacks_mappings == null) {
				package_com_confirmit_mobilesdk_surveyengine_runner_stacks_mappings = new string[]{
					"com/confirmit/mobilesdk/surveyengine/runner/stacks/a:Com.Confirmit.Mobilesdk.Surveyengine.Runner.Stacks.SurveyEngineRunnerStacksA",
					"com/confirmit/mobilesdk/surveyengine/runner/stacks/b:Com.Confirmit.Mobilesdk.Surveyengine.Runner.Stacks.SurveyEngineRunnerStacksB",
				};
			}

			return Lookup (package_com_confirmit_mobilesdk_surveyengine_runner_stacks_mappings, klass);
		}

		static string[] package_com_confirmit_mobilesdk_sync_mappings;
		static Type lookup_com_confirmit_mobilesdk_sync_package (string klass)
		{
			if (package_com_confirmit_mobilesdk_sync_mappings == null) {
				package_com_confirmit_mobilesdk_sync_mappings = new string[]{
					"com/confirmit/mobilesdk/sync/a:Com.Confirmit.Mobilesdk.Sync.SyncA",
					"com/confirmit/mobilesdk/sync/b:Com.Confirmit.Mobilesdk.Sync.SyncB",
				};
			}

			return Lookup (package_com_confirmit_mobilesdk_sync_mappings, klass);
		}

		static string[] package_com_confirmit_mobilesdk_sync_domain_mappings;
		static Type lookup_com_confirmit_mobilesdk_sync_domain_package (string klass)
		{
			if (package_com_confirmit_mobilesdk_sync_domain_mappings == null) {
				package_com_confirmit_mobilesdk_sync_domain_mappings = new string[]{
					"com/confirmit/mobilesdk/sync/domain/b:Com.Confirmit.Mobilesdk.Sync.Domain.SyncDomainB",
					"com/confirmit/mobilesdk/sync/domain/c:Com.Confirmit.Mobilesdk.Sync.Domain.SyncDomainC",
					"com/confirmit/mobilesdk/sync/domain/f:Com.Confirmit.Mobilesdk.Sync.Domain.SyncDomainF",
					"com/confirmit/mobilesdk/sync/domain/g:Com.Confirmit.Mobilesdk.Sync.Domain.SyncDomainG",
					"com/confirmit/mobilesdk/sync/domain/h:Com.Confirmit.Mobilesdk.Sync.Domain.SyncDomainH",
					"com/confirmit/mobilesdk/sync/domain/o:Com.Confirmit.Mobilesdk.Sync.Domain.SyncDomainO",
				};
			}

			return Lookup (package_com_confirmit_mobilesdk_sync_domain_mappings, klass);
		}

		static string[] package_com_confirmit_mobilesdk_sync_domain_infos_mappings;
		static Type lookup_com_confirmit_mobilesdk_sync_domain_infos_package (string klass)
		{
			if (package_com_confirmit_mobilesdk_sync_domain_infos_mappings == null) {
				package_com_confirmit_mobilesdk_sync_domain_infos_mappings = new string[]{
					"com/confirmit/mobilesdk/sync/domain/infos/a:Com.Confirmit.Mobilesdk.Sync.Domain.Infos.SyncDomainInfosA",
				};
			}

			return Lookup (package_com_confirmit_mobilesdk_sync_domain_infos_mappings, klass);
		}

		static string[] package_com_confirmit_mobilesdk_sync_payloads_mappings;
		static Type lookup_com_confirmit_mobilesdk_sync_payloads_package (string klass)
		{
			if (package_com_confirmit_mobilesdk_sync_payloads_mappings == null) {
				package_com_confirmit_mobilesdk_sync_payloads_mappings = new string[]{
					"com/confirmit/mobilesdk/sync/payloads/a:Com.Confirmit.Mobilesdk.Sync.Payloads.SyncPayloadsA",
					"com/confirmit/mobilesdk/sync/payloads/b:Com.Confirmit.Mobilesdk.Sync.Payloads.SyncPayloadsB",
					"com/confirmit/mobilesdk/sync/payloads/c:Com.Confirmit.Mobilesdk.Sync.Payloads.SyncPayloadsC",
					"com/confirmit/mobilesdk/sync/payloads/d:Com.Confirmit.Mobilesdk.Sync.Payloads.SyncPayloadsD",
					"com/confirmit/mobilesdk/sync/payloads/e:Com.Confirmit.Mobilesdk.Sync.Payloads.SyncPayloadsE",
				};
			}

			return Lookup (package_com_confirmit_mobilesdk_sync_payloads_mappings, klass);
		}

		static string[] package_com_confirmit_mobilesdk_sync_request_mappings;
		static Type lookup_com_confirmit_mobilesdk_sync_request_package (string klass)
		{
			if (package_com_confirmit_mobilesdk_sync_request_mappings == null) {
				package_com_confirmit_mobilesdk_sync_request_mappings = new string[]{
					"com/confirmit/mobilesdk/sync/request/a:Com.Confirmit.Mobilesdk.Sync.Request.SyncRequestA",
					"com/confirmit/mobilesdk/sync/request/b:Com.Confirmit.Mobilesdk.Sync.Request.SyncRequestB",
					"com/confirmit/mobilesdk/sync/request/c:Com.Confirmit.Mobilesdk.Sync.Request.SyncRequestC",
				};
			}

			return Lookup (package_com_confirmit_mobilesdk_sync_request_mappings, klass);
		}

		static string[] package_com_confirmit_mobilesdk_sync_request_defaults_mappings;
		static Type lookup_com_confirmit_mobilesdk_sync_request_defaults_package (string klass)
		{
			if (package_com_confirmit_mobilesdk_sync_request_defaults_mappings == null) {
				package_com_confirmit_mobilesdk_sync_request_defaults_mappings = new string[]{
					"com/confirmit/mobilesdk/sync/request/defaults/a:Com.Confirmit.Mobilesdk.Sync.Request.Defaults.SyncRequestDefaultsA",
					"com/confirmit/mobilesdk/sync/request/defaults/b:Com.Confirmit.Mobilesdk.Sync.Request.Defaults.SyncRequestDefaultsB",
					"com/confirmit/mobilesdk/sync/request/defaults/c:Com.Confirmit.Mobilesdk.Sync.Request.Defaults.SyncRequestDefaultsC",
					"com/confirmit/mobilesdk/sync/request/defaults/d:Com.Confirmit.Mobilesdk.Sync.Request.Defaults.SyncRequestDefaultsD",
					"com/confirmit/mobilesdk/sync/request/defaults/e:Com.Confirmit.Mobilesdk.Sync.Request.Defaults.SyncRequestDefaultsE",
				};
			}

			return Lookup (package_com_confirmit_mobilesdk_sync_request_defaults_mappings, klass);
		}

		static string[] package_com_confirmit_mobilesdk_sync_responsemodels_mappings;
		static Type lookup_com_confirmit_mobilesdk_sync_responsemodels_package (string klass)
		{
			if (package_com_confirmit_mobilesdk_sync_responsemodels_mappings == null) {
				package_com_confirmit_mobilesdk_sync_responsemodels_mappings = new string[]{
					"com/confirmit/mobilesdk/sync/responsemodels/a:Com.Confirmit.Mobilesdk.Sync.Responsemodels.SyncResponseModelsA",
					"com/confirmit/mobilesdk/sync/responsemodels/b:Com.Confirmit.Mobilesdk.Sync.Responsemodels.SyncResponseModelsB",
					"com/confirmit/mobilesdk/sync/responsemodels/c:Com.Confirmit.Mobilesdk.Sync.Responsemodels.SyncResponseModelssC",
					"com/confirmit/mobilesdk/sync/responsemodels/d:Com.Confirmit.Mobilesdk.Sync.Responsemodels.SyncResponseModelsD",
					"com/confirmit/mobilesdk/sync/responsemodels/e:Com.Confirmit.Mobilesdk.Sync.Responsemodels.SyncResponseModelsE",
				};
			}

			return Lookup (package_com_confirmit_mobilesdk_sync_responsemodels_mappings, klass);
		}

		static string[] package_com_confirmit_mobilesdk_trigger_mappings;
		static Type lookup_com_confirmit_mobilesdk_trigger_package (string klass)
		{
			if (package_com_confirmit_mobilesdk_trigger_mappings == null) {
				package_com_confirmit_mobilesdk_trigger_mappings = new string[]{
					"com/confirmit/mobilesdk/trigger/a:Com.Confirmit.Mobilesdk.Trigger.TriggerA",
					"com/confirmit/mobilesdk/trigger/b:Com.Confirmit.Mobilesdk.Trigger.TriggerB",
					"com/confirmit/mobilesdk/trigger/c:Com.Confirmit.Mobilesdk.Trigger.TriggerC",
					"com/confirmit/mobilesdk/trigger/d:Com.Confirmit.Mobilesdk.Trigger.TriggerD",
					"com/confirmit/mobilesdk/trigger/e:Com.Confirmit.Mobilesdk.Trigger.TriggerE",
				};
			}

			return Lookup (package_com_confirmit_mobilesdk_trigger_mappings, klass);
		}

		static string[] package_com_confirmit_mobilesdk_ui_mappings;
		static Type lookup_com_confirmit_mobilesdk_ui_package (string klass)
		{
			if (package_com_confirmit_mobilesdk_ui_mappings == null) {
				package_com_confirmit_mobilesdk_ui_mappings = new string[]{
					"com/confirmit/mobilesdk/ui/a:Com.Confirmit.Mobilesdk.UI.UIA",
					"com/confirmit/mobilesdk/ui/b:Com.Confirmit.Mobilesdk.UI.UIB",
				};
			}

			return Lookup (package_com_confirmit_mobilesdk_ui_mappings, klass);
		}

		static string[] package_com_confirmit_mobilesdk_utils_mappings;
		static Type lookup_com_confirmit_mobilesdk_utils_package (string klass)
		{
			if (package_com_confirmit_mobilesdk_utils_mappings == null) {
				package_com_confirmit_mobilesdk_utils_mappings = new string[]{
					"com/confirmit/mobilesdk/utils/a:Com.Confirmit.Mobilesdk.Utils.UtilsA",
					"com/confirmit/mobilesdk/utils/b:Com.Confirmit.Mobilesdk.Utils.UtilsB",
					"com/confirmit/mobilesdk/utils/c:Com.Confirmit.Mobilesdk.Utils.UtilsC",
					"com/confirmit/mobilesdk/utils/d:Com.Confirmit.Mobilesdk.Utils.UtilsD",
					"com/confirmit/mobilesdk/utils/f:Com.Confirmit.Mobilesdk.Utils.UtilsF",
					"com/confirmit/mobilesdk/utils/g:Com.Confirmit.Mobilesdk.Utils.UtilsG",
					"com/confirmit/mobilesdk/utils/h:Com.Confirmit.Mobilesdk.Utils.UtilsH",
					"com/confirmit/mobilesdk/utils/i:Com.Confirmit.Mobilesdk.Utils.UtilsI",
				};
			}

			return Lookup (package_com_confirmit_mobilesdk_utils_mappings, klass);
		}

		static string[] package_com_confirmit_mobilesdk_web_mappings;
		static Type lookup_com_confirmit_mobilesdk_web_package (string klass)
		{
			if (package_com_confirmit_mobilesdk_web_mappings == null) {
				package_com_confirmit_mobilesdk_web_mappings = new string[]{
					"com/confirmit/mobilesdk/web/a:Com.Confirmit.Mobilesdk.Web.WebA",
					"com/confirmit/mobilesdk/web/b:Com.Confirmit.Mobilesdk.Web.WebB",
					"com/confirmit/mobilesdk/web/c:Com.Confirmit.Mobilesdk.Web.WebC",
				};
			}

			return Lookup (package_com_confirmit_mobilesdk_web_mappings, klass);
		}
	}
}
