﻿namespace HermesProxy.Framework.Constants;

public enum BattlenetRpcErrorCode : uint
{
    Ok = 0x00000000,
    Internal = 0x00000001,
    TimedOut = 0x00000002,
    Denied = 0x00000003,
    NotExists = 0x00000004,
    NotStarted = 0x00000005,
    InProgress = 0x00000006,
    InvalidArgs = 0x00000007,
    InvalidSubscriber = 0x00000008,
    WaitingForDependency = 0x00000009,
    NoAuth = 0x0000000a,
    ParentalControlRestriction = 0x0000000b,
    NoGameAccount = 0x0000000c,
    NotImplemented = 0x0000000d,
    ObjectRemoved = 0x0000000e,
    InvalidEntityId = 0x0000000f,
    InvalidEntityAccountId = 0x00000010,
    InvalidEntityGameAccountId = 0x00000011,
    InvalidAgentId = 0x00000013,
    InvalidTargetId = 0x00000014,
    ModuleNotLoaded = 0x00000015,
    ModuleNoEntryPoint = 0x00000016,
    ModuleSignatureIncorrect = 0x00000017,
    ModuleCreateFailed = 0x00000018,
    NoProgram = 0x00000019,
    ApiNotReady = 0x0000001b,
    BadVersion = 0x0000001c,
    AttributeTooManyAttributesSet = 0x0000001d,
    AttributeMaxSizeExceeded = 0x0000001e,
    AttributeQuotaExceeded = 0x0000001f,
    ServerPoolServerDisappeared = 0x00000020,
    ServerIsPrivate = 0x00000021,
    Disabled = 0x00000022,
    ModuleNotFound = 0x00000024,
    ServerBusy = 0x00000025,
    NoBattletag = 0x00000026,
    IncompleteProfanityFilters = 0x00000027,
    InvalidRegion = 0x00000028,
    ExistsAlready = 0x00000029,
    InvalidServerThumbprint = 0x0000002a,
    PhoneLock = 0x0000002b,
    Squelched = 0x0000002c,
    TargetOffline = 0x0000002d,
    BadServer = 0x0000002e,
    NoCookie = 0x0000002f,
    ExpiredCookie = 0x00000030,
    TokenNotFound = 0x00000031,
    GameAccountNoTime = 0x00000032,
    GameAccountNoPlan = 0x00000033,
    GameAccountBanned = 0x00000034,
    GameAccountSuspended = 0x00000035,
    GameAccountAlreadySelected = 0x00000036,
    GameAccountCancelled = 0x00000037,
    GameAccountCreationDisabled = 0x00000038,
    GameAccountLocked = 0x00000039,

    SessionDuplicate = 0x0000003c,
    SessionDisconnected = 0x0000003d,
    SessionDataChanged = 0x0000003e,
    SessionUpdateFailed = 0x0000003f,
    SessionNotFound = 0x00000040,

    AdminKick = 0x00000046,
    UnplannedMaintenance = 0x00000047,
    PlannedMaintenance = 0x00000048,
    ServiceFailureAccount = 0x00000049,
    ServiceFailureSession = 0x0000004a,
    ServiceFailureAuth = 0x0000004b,
    ServiceFailureRisk = 0x0000004c,
    BadProgram = 0x0000004d,
    BadLocale = 0x0000004e,
    BadPlatform = 0x0000004f,
    LocaleRestrictedLa = 0x00000051,
    LocaleRestrictedRu = 0x00000052,
    LocaleRestrictedKo = 0x00000053,
    LocaleRestrictedTw = 0x00000054,
    LocaleRestricted = 0x00000055,
    AccountNeedsMaintenance = 0x00000056,
    ModuleApiError = 0x00000057,
    ModuleBadCacheHandle = 0x00000058,
    ModuleAlreadyLoaded = 0x00000059,
    NetworkBlacklisted = 0x0000005a,
    EventProcessorSlow = 0x0000005b,
    ServerShuttingDown = 0x0000005c,
    NetworkNotPrivileged = 0x0000005d,
    TooManyOutstandingRequests = 0x0000005e,
    NoAccountRegistered = 0x0000005f,
    BattlenetAccountBanned = 0x00000060,

    OkDeprecated = 0x00000064,
    ServerInModeZombie = 0x00000065,

    LogonModuleRequired = 0x000001f4,
    LogonModuleNotConfigured = 0x000001f5,
    LogonModuleTimeout = 0x000001f6,
    LogonAgreementRequired = 0x000001fe,
    LogonAgreementNotConfigured = 0x000001ff,

    LogonInvalidServerProof = 0x00000208,
    LogonWebVerifyTimeout = 0x00000209,
    LogonInvalidAuthToken = 0x0000020a,

    ChallengeSmsTooSoon = 0x00000258,
    ChallengeSmsThrottled = 0x00000259,
    ChallengeSmsTempOutage = 0x0000025a,
    ChallengeNoChallenge = 0x0000025b,
    ChallengeNotPicked = 0x0000025c,
    ChallengeAlreadyPicked = 0x0000025d,
    ChallengeInProgress = 0x0000025e,

    ConfigFormatInvalid = 0x000002bc,
    ConfigNotFound = 0x000002bd,
    ConfigRetrieveFailed = 0x000002be,

    NetworkModuleBusy = 0x000003e8,
    NetworkModuleCantResolveAddress = 0x000003e9,
    NetworkModuleConnectionRefused = 0x000003ea,
    NetworkModuleInterrupted = 0x000003eb,
    NetworkModuleConnectionAborted = 0x000003ec,
    NetworkModuleConnectionReset = 0x000003ed,
    NetworkModuleBadAddress = 0x000003ee,
    NetworkModuleNotReady = 0x000003ef,
    NetworkModuleAlreadyConnected = 0x000003f0,
    NetworkModuleCantCreateSocket = 0x000003f1,
    NetworkModuleNetworkUnreachable = 0x000003f2,
    NetworkModuleSocketPermissionDenied = 0x000003f3,
    NetworkModuleNotInitialized = 0x000003f4,
    NetworkModuleNoSslCertificateForPeer = 0x000003f5,
    NetworkModuleNoSslCommonNameForCertificate = 0x000003f6,
    NetworkModuleSslCommonNameDoesNotMatchRemoteEndpoint = 0x000003f7,
    NetworkModuleSocketClosed = 0x000003f8,
    NetworkModuleSslPeerIsNotRegisteredInCertbundle = 0x000003f9,
    NetworkModuleSslInitializeLowFirst = 0x000003fa,
    NetworkModuleSslCertBundleReadError = 0x000003fb,
    NetworkModuleNoCertBundle = 0x000003fc,
    NetworkModuleFailedToDownloadCertBundle = 0x000003fd,
    NetworkModuleNotReadyToRead = 0x000003fe,

    NetworkModuleOpensslX509Ok = 0x000004b0,
    NetworkModuleOpensslX509UnableToGetIssuerCert = 0x000004b1,
    NetworkModuleOpensslX509UnableToGetCrl = 0x000004b2,
    NetworkModuleOpensslX509UnableToDecryptCertSignature = 0x000004b3,
    NetworkModuleOpensslX509UnableToDecryptCrlSignature = 0x000004b4,
    NetworkModuleOpensslX509UnableToDecodeIssuerPublicKey = 0x000004b5,
    NetworkModuleOpensslX509CertSignatureFailure = 0x000004b6,
    NetworkModuleOpensslX509CrlSignatureFailure = 0x000004b7,
    NetworkModuleOpensslX509CertNotYetValid = 0x000004b8,
    NetworkModuleOpensslX509CertHasExpired = 0x000004b9,
    NetworkModuleOpensslX509CrlNotYetValid = 0x000004ba,
    NetworkModuleOpensslX509CrlHasExpired = 0x000004bb,
    NetworkModuleOpensslX509InCertNotBeforeField = 0x000004bc,
    NetworkModuleOpensslX509InCertNotAfterField = 0x000004bd,
    NetworkModuleOpensslX509InCrlLastUpdateField = 0x000004be,
    NetworkModuleOpensslX509InCrlNextUpdateField = 0x000004bf,
    NetworkModuleOpensslX509OutOfMem = 0x000004c0,
    NetworkModuleOpensslX509DepthZeroSelfSignedCert = 0x000004c1,
    NetworkModuleOpensslX509SelfSignedCertInChain = 0x000004c2,
    NetworkModuleOpensslX509UnableToGetIssuerCertLocally = 0x000004c3,
    NetworkModuleOpensslX509UnableToVerifyLeafSignature = 0x000004c4,
    NetworkModuleOpensslX509CertChainTooLong = 0x000004c5,
    NetworkModuleOpensslX509CertRevoked = 0x000004c6,
    NetworkModuleOpensslX509InvalidCa = 0x000004c7,
    NetworkModuleOpensslX509PathLengthExceeded = 0x000004c8,
    NetworkModuleOpensslX509InvalidPurpose = 0x000004c9,
    NetworkModuleOpensslX509CertUntrusted = 0x000004ca,
    NetworkModuleOpensslX509CertRejected = 0x000004cb,
    NetworkModuleOpensslX509SubjectIssuerMismatch = 0x000004cc,
    NetworkModuleOpensslX509AkidSkidMismatch = 0x000004cd,
    NetworkModuleOpensslX509AkidIssuerSerialMismatch = 0x000004ce,
    NetworkModuleOpensslX509KeyusageNoCertsign = 0x000004cf,
    NetworkModuleOpensslX509ApplicationVerification = 0x000004d0,

    NetworkModuleSchannelCannotFindOsVersion = 0x00000514,
    NetworkModuleSchannelOsNotSupported = 0x00000515,
    NetworkModuleSchannelLoadlibraryFail = 0x00000516,
    NetworkModuleSchannelCannotFindInterface = 0x00000517,
    NetworkModuleSchannelInitFail = 0x00000518,
    NetworkModuleSchannelFunctionCallFail = 0x00000519,
    NetworkModuleSchannelX509UnableToGetIssuerCert = 0x00000546,
    NetworkModuleSchannelX509TimeInvalid = 0x00000547,
    NetworkModuleSchannelX509SignatureInvalid = 0x00000548,
    NetworkModuleSchannelX509UnableToVerifyLeafSignature = 0x00000549,
    NetworkModuleSchannelX509SelfSignedLeafCertificate = 0x0000054a,
    NetworkModuleSchannelX509UnhandledError = 0x0000054b,
    NetworkModuleSchannelX509SelfSignedCertInChain = 0x0000054c,

    WebsocketHandshake = 0x00000578,

    NetworkModuleDurangoUnknown = 0x000005dc,
    NetworkModuleDurangoMalformedHostName = 0x000005dd,
    NetworkModuleDurangoInvalidConnectionResponse = 0x000005de,
    NetworkModuleDurangoInvalidCaCert = 0x000005df,

    RpcWriteFailed = 0x00000bb8,
    RpcServiceNotBound = 0x00000bb9,
    RpcTooManyRequests = 0x00000bba,
    RpcPeerUnknown = 0x00000bbb,
    RpcPeerUnavailable = 0x00000bbc,
    RpcPeerDisconnected = 0x00000bbd,
    RpcRequestTimedOut = 0x00000bbe,
    RpcConnectionTimedOut = 0x00000bbf,
    RpcMalformedResponse = 0x00000bc0,
    RpcAccessDenied = 0x00000bc1,
    RpcInvalidService = 0x00000bc2,
    RpcInvalidMethod = 0x00000bc3,
    RpcInvalidObject = 0x00000bc4,
    RpcMalformedRequest = 0x00000bc5,
    RpcQuotaExceeded = 0x00000bc6,
    RpcNotImplemented = 0x00000bc7,
    RpcServerError = 0x00000bc8,
    RpcShutdown = 0x00000bc9,
    RpcDisconnect = 0x00000bca,
    RpcDisconnectIdle = 0x00000bcb,
    RpcProtocolError = 0x00000bcc,
    RpcNotReady = 0x00000bcd,
    RpcForwardFailed = 0x00000bce,
    RpcEncryptionFailed = 0x00000bcf,
    RpcInvalidAddress = 0x00000bd0,
    RpcMethodDisabled = 0x00000bd1,
    RpcShardNotFound = 0x00000bd2,
    RpcInvalidConnectionId = 0x00000bd3,
    RpcNotConnected = 0x00000bd4,
    RpcInvalidConnectionState = 0x00000bd5,
    RpcServiceAlreadyRegistered = 0x00000bd6,

    PresenceInvalidFieldId = 0x00000fa0,
    PresenceNoValidSubscribers = 0x00000fa1,
    PresenceAlreadySubscribed = 0x00000fa2,
    PresenceConsumerNotFound = 0x00000fa3,
    PresenceConsumerIsNull = 0x00000fa4,
    PresenceTemporaryOutage = 0x00000fa5,
    PresenceTooManySubscriptions = 0x00000fa6,
    PresenceSubscriptionCancelled = 0x00000fa7,
    PresenceRichPresenceParseError = 0x00000fa8,
    PresenceRichPresenceXmlError = 0x00000fa9,
    PresenceRichPresenceLoadError = 0x00000faa,

    FriendsTooManySentInvitations = 0x00001389,
    FriendsTooManyReceivedInvitations = 0x0000138a,
    FriendsFriendshipAlreadyExists = 0x0000138b,
    FriendsFriendshipDoesNotExist = 0x0000138c,
    FriendsInvitationAlreadyExists = 0x0000138d,
    FriendsInvalidInvitation = 0x0000138e,
    FriendsAlreadySubscribed = 0x0000138f,
    FriendsAccountBlocked = 0x00001391,
    FriendsNotSubscribed = 0x00001392,
    FriendsInvalidRoleId = 0x00001393,
    FriendsDisabledRoleId = 0x00001394,
    FriendsNoteMaxSizeExceeded = 0x00001395,
    FriendsUpdateFriendStateFailed = 0x00001396,
    FriendsInviteeAtMaxFriends = 0x00001397,
    FriendsInviterAtMaxFriends = 0x00001398,

    PlatformStorageFileWriteDenied = 0x00001770,

    WhisperUndeliverable = 0x00001b58,
    WhisperMaxSizeExceeded = 0x00001b59,

    UserManagerAlreadyBlocked = 0x00001f40,
    UserManagerNotBlocked = 0x00001f41,
    UserManagerCannotBlockSelf = 0x00001f42,
    UserManagerAlreadyRegistered = 0x00001f43,
    UserManagerNotRegistered = 0x00001f44,
    UserManagerTooManyBlockedEntities = 0x00001f45,
    UserManagerTooManyIds = 0x00001f47,
    UserManagerBlockRecordUnavailable = 0x00001f4f,
    UserManagerBlockEntityFailed = 0x00001f50,
    UserManagerUnblockEntityFailed = 0x00001f51,
    UserManagerCannotBlockFriend = 0x00001f53,

    SocialNetworkDbException = 0x00002328,
    SocialNetworkDenialFromProvider = 0x00002329,
    SocialNetworkInvalidSnsId = 0x0000232a,
    SocialNetworkCantSendToProvider = 0x0000232b,
    SocialNetworkExCommFailed = 0x0000232c,
    SocialNetworkDisabled = 0x0000232d,
    SocialNetworkMissingRequestParam = 0x0000232e,
    SocialNetworkUnsupportedOauthVersion = 0x0000232f,

    ChannelFull = 0x00002710,
    ChannelNoChannel = 0x00002711,
    ChannelNotMember = 0x00002712,
    ChannelAlreadyMember = 0x00002713,
    ChannelNoSuchMember = 0x00002714,
    ChannelInvalidChannelId = 0x00002716,
    ChannelNoSuchInvitation = 0x00002718,
    ChannelTooManyInvitations = 0x00002719,
    ChannelInvitationAlreadyExists = 0x0000271a,
    ChannelInvalidChannelSize = 0x0000271b,
    ChannelInvalidRoleId = 0x0000271c,
    ChannelRoleNotAssignable = 0x0000271d,
    ChannelInsufficientPrivileges = 0x0000271e,
    ChannelInsufficientPrivacyLevel = 0x0000271f,
    ChannelInvalidPrivacyLevel = 0x00002720,
    ChannelTooManyChannelsJoined = 0x00002721,
    ChannelInvitationAlreadySubscribed = 0x00002722,
    ChannelInvalidChannelDelegate = 0x00002723,
    ChannelSlotAlreadyReserved = 0x00002724,
    ChannelSlotNotReserved = 0x00002725,
    ChannelNoReservedSlotsAvailable = 0x00002726,
    ChannelInvalidRoleSet = 0x00002727,
    ChannelRequireFriendValidation = 0x00002728,
    ChannelMemberOffline = 0x00002729,
    ChannelReceivedTooManyInvitations = 0x0000272a,
    ChannelInvitationInvalidGameAccountSelected = 0x0000272b,
    ChannelUnreachable = 0x0000272c,
    ChannelInvitationNotSubscribed = 0x0000272d,
    ChannelInvalidMessageSize = 0x0000272e,
    ChannelMaxMessageSizeExceeded = 0x0000272f,
    ChannelConfigNotFound = 0x00002730,
    ChannelInvalidChannelType = 0x00002731,

    LocalStorageFileOpenError = 0x00002af8,
    LocalStorageFileCreateError = 0x00002af9,
    LocalStorageFileReadError = 0x00002afa,
    LocalStorageFileWriteError = 0x00002afb,
    LocalStorageFileDeleteError = 0x00002afc,
    LocalStorageFileCopyError = 0x00002afd,
    LocalStorageFileDecompressError = 0x00002afe,
    LocalStorageFileHashMismatch = 0x00002aff,
    LocalStorageFileUsageMismatch = 0x00002b00,
    LocalStorageDatabaseInitError = 0x00002b01,
    LocalStorageDatabaseNeedsRebuild = 0x00002b02,
    LocalStorageDatabaseInsertError = 0x00002b03,
    LocalStorageDatabaseLookupError = 0x00002b04,
    LocalStorageDatabaseUpdateError = 0x00002b05,
    LocalStorageDatabaseDeleteError = 0x00002b06,
    LocalStorageDatabaseShrinkError = 0x00002b07,
    LocalStorageCacheCrawlError = 0x00002b08,
    LocalStorageDatabaseIndexTriggerError = 0x00002b09,
    LocalStorageDatabaseRebuildInProgress = 0x00002b0a,
    LocalStorageOkButNotInCache = 0x00002b0b,
    LocalStorageDatabaseRebuildInterrupted = 0x00002b0d,
    LocalStorageDatabaseNotInitialized = 0x00002b0e,
    LocalStorageDirectoryCreateError = 0x00002b0f,
    LocalStorageFilekeyNotFound = 0x00002b10,
    LocalStorageNotAvailableOnServer = 0x00002b11,

    RegistryCreateKeyError = 0x00002ee0,
    RegistryOpenKeyError = 0x00002ee1,
    RegistryReadError = 0x00002ee2,
    RegistryWriteError = 0x00002ee3,
    RegistryTypeError = 0x00002ee4,
    RegistryDeleteError = 0x00002ee5,
    RegistryEncryptError = 0x00002ee6,
    RegistryDecryptError = 0x00002ee7,
    RegistryKeySizeError = 0x00002ee8,
    RegistryValueSizeError = 0x00002ee9,
    RegistryNotFound = 0x00002eeb,
    RegistryMalformedString = 0x00002eec,

    InterfaceAlreadyConnected = 0x000032c8,
    InterfaceNotReady = 0x000032c9,
    InterfaceOptionKeyTooLarge = 0x000032ca,
    InterfaceOptionValueTooLarge = 0x000032cb,
    InterfaceOptionKeyInvalidUtf8String = 0x000032cc,
    InterfaceOptionValueInvalidUtf8String = 0x000032cd,

    HttpCouldntResolve = 0x000036b0,
    HttpCouldntConnect = 0x000036b1,
    HttpTimeout = 0x000036b2,
    HttpFailed = 0x000036b3,
    HttpMalformedUrl = 0x000036b4,
    HttpDownloadAborted = 0x000036b5,
    HttpCouldntWriteFile = 0x000036b6,
    HttpTooManyRedirects = 0x000036b7,
    HttpCouldntOpenFile = 0x000036b8,
    HttpCouldntCreateFile = 0x000036b9,
    HttpCouldntReadFile = 0x000036ba,
    HttpCouldntRenameFile = 0x000036bb,
    HttpCouldntCreateDirectory = 0x000036bc,
    HttpCurlIsNotReady = 0x000036bd,
    HttpCancelled = 0x000036be,

    HttpFileNotFound = 0x00003844,

    AccountMissingConfig = 0x00004650,
    AccountDataNotFound = 0x00004651,
    AccountAlreadySubscribed = 0x00004652,
    AccountNotSubscribed = 0x00004653,
    AccountFailedToParseTimezoneData = 0x00004654,
    AccountLoadFailed = 0x00004655,
    AccountLoadCancelled = 0x00004656,
    AccountDatabaseInvalidateFailed = 0x00004657,
    AccountCacheInvalidateFailed = 0x00004658,
    AccountSubscriptionPending = 0x00004659,
    AccountUnknownRegion = 0x0000465a,
    AccountDataFailedToParse = 0x0000465b,
    AccountUnderage = 0x0000465c,
    AccountIdentityCheckPending = 0x0000465d,
    AccountIdentityUnverified = 0x0000465e,

    DatabaseBindingCountMismatch = 0x00004a38,
    DatabaseBindingParseFail = 0x00004a39,
    DatabaseResultsetColumnsMismatch = 0x00004a3a,
    DatabaseDeadlock = 0x00004a3b,
    DatabaseDuplicateKey = 0x00004a3c,
    DatabaseCannotConnect = 0x00004a3d,
    DatabaseStatementFailed = 0x00004a3e,
    DatabaseTransactionNotStarted = 0x00004a3f,
    DatabaseTransactionNotEnded = 0x00004a40,
    DatabaseTransactionLeak = 0x00004a41,
    DatabaseTransactionStateBad = 0x00004a42,
    DatabaseServerGone = 0x00004a43,
    DatabaseQueryTimeout = 0x00004a44,
    DatabaseBindingNotNullable = 0x00004a9c,
    DatabaseBindingInvalidInteger = 0x00004a9d,
    DatabaseBindingInvalidFloat = 0x00004a9e,
    DatabaseBindingInvalidTemporal = 0x00004a9f,
    DatabaseBindingInvalidProtobuf = 0x00004aa0,

    PartyInvalidPartyId = 0x00004e20,
    PartyAlreadyInParty = 0x00004e21,
    PartyNotInParty = 0x00004e22,
    PartyInvitationUndeliverable = 0x00004e23,
    PartyInvitationAlreadyExists = 0x00004e24,
    PartyTooManyPartyInvitations = 0x00004e25,
    PartyTooManyReceivedInvitations = 0x00004e26,
    PartyNoSuchType = 0x00004e27,

    GamesNoSuchFactory = 0x000055f0,
    GamesNoSuchGame = 0x000055f1,
    GamesNoSuchRequest = 0x000055f2,
    GamesNoSuchPartyMember = 0x000055f3,

    ResourcesOffline = 0x000059d8,

    GameServerCreateGameRefused = 0x00005dc0,
    GameServerAddPlayersRefused = 0x00005dc1,
    GameServerRemovePlayersRefused = 0x00005dc2,
    GameServerFinishGameRefused = 0x00005dc3,
    GameServerNoSuchGame = 0x00005dc4,
    GameServerNoSuchPlayer = 0x00005dc5,
    GameServerCreateGameRefusedTransient = 0x00005df2,
    GameServerAddPlayersRefusedTransient = 0x00005df3,
    GameServerRemovePlayersRefusedTransient = 0x00005df4,
    GameServerFinishGameRefusedTransient = 0x00005df5,
    GameServerCreateGameRefusedBusy = 0x00005e24,
    GameServerAddPlayersRefusedBusy = 0x00005e25,
    GameServerRemovePlayersRefusedBusy = 0x00005e26,
    GameServerFinishGameRefusedBusy = 0x00005e27,

    GameMasterInvalidFactory = 0x000061a8,
    GameMasterInvalidGame = 0x000061a9,
    GameMasterGameFull = 0x000061aa,
    GameMasterRegisterFailed = 0x000061ab,
    GameMasterNoGameServer = 0x000061ac,
    GameMasterNoUtilityServer = 0x000061ad,
    GameMasterNoGameVersion = 0x000061ae,
    GameMasterGameJoinFailed = 0x000061af,
    GameMasterAlreadyRegistered = 0x000061b0,
    GameMasterNoFactory = 0x000061b1,
    GameMasterMultipleGameVersions = 0x000061b2,
    GameMasterInvalidPlayer = 0x000061b3,
    GameMasterInvalidGameRequest = 0x000061b4,
    GameMasterInsufficientPrivileges = 0x000061b5,
    GameMasterAlreadyInGame = 0x000061b6,
    GameMasterInvalidGameServerResponse = 0x000061b7,
    GameMasterGameAccountLookupFailed = 0x000061b8,
    GameMasterGameEntryCancelled = 0x000061b9,
    GameMasterGameEntryAbortedClientDropped = 0x000061ba,
    GameMasterGameEntryAbortedByService = 0x000061bb,
    GameMasterNoAvailableCapacity = 0x000061bc,
    GameMasterInvalidTeamId = 0x000061bd,
    GameMasterCreationInProgress = 0x000061be,

    NotificationInvalidClientId = 0x00006590,
    NotificationDuplicateName = 0x00006591,
    NotificationNameNotFound = 0x00006592,
    NotificationInvalidServer = 0x00006593,
    NotificationQuotaExceeded = 0x00006594,
    NotificationInvalidNotificationType = 0x00006595,
    NotificationUndeliverable = 0x00006596,
    NotificationUndeliverableTemporary = 0x00006597,

    AchievementsNothingToUpdate = 0x00006d60,
    AchievementsInvalidParams = 0x00006d61,
    AchievementsNotRegistered = 0x00006d62,
    AchievementsNotReady = 0x00006d63,
    AchievementsFailedToParseStaticData = 0x00006d64,
    AchievementsUnknownId = 0x00006d65,
    AchievementsMissingSnapshot = 0x00006d66,
    AchievementsAlreadyRegistered = 0x00006d67,
    AchievementsTooManyRegistrations = 0x00006d68,
    AchievementsAlreadyInProgress = 0x00006d69,
    AchievementsTemporaryOutage = 0x00006d6a,
    AchievementsInvalidProgramid = 0x00006d6b,
    AchievementsMissingRecord = 0x00006d6c,
    AchievementsRegistrationPending = 0x00006d6d,
    AchievementsEntityIdNotFound = 0x00006d6e,
    AchievementsAchievementIdNotFound = 0x00006d6f,
    AchievementsCriteriaIdNotFound = 0x00006d70,
    AchievementsStaticDataMismatch = 0x00006d71,
    AchievementsWrongThread = 0x00006d72,
    AchievementsCallbackIsNull = 0x00006d73,
    AchievementsAutoRegisterPending = 0x00006d74,
    AchievementsNotInitialized = 0x00006d75,
    AchievementsAchievementIdAlreadyExists = 0x00006d76,
    AchievementsFailedToDownloadStaticData = 0x00006d77,
    AchievementsStaticDataNotFound = 0x00006d78,

    GameUtilityServerVariableRequestRefused = 0x000084d1,
    GameUtilityServerWrongNumberOfVariablesReturned = 0x000084d2,
    GameUtilityServerClientRequestRefused = 0x000084d3,
    GameUtilityServerPresenceChannelCreatedRefused = 0x000084d4,
    GameUtilityServerVariableRequestRefusedTransient = 0x00008502,
    GameUtilityServerClientRequestRefusedTransient = 0x00008503,
    GameUtilityServerPresenceChannelCreatedRefusedTransient = 0x00008504,
    GameUtilityServerServerRequestRefusedTransient = 0x00008505,
    GameUtilityServerVariableRequestRefusedBusy = 0x00008534,
    GameUtilityServerClientRequestRefusedBusy = 0x00008535,
    GameUtilityServerPresenceChannelCreatedRefusedBusy = 0x00008536,
    GameUtilityServerServerRequestRefusedBusy = 0x00008537,
    GameUtilityServerNoServer = 0x00008598,

    IdentityInsufficientData = 0x0000a028,
    IdentityTooManyResults = 0x0000a029,
    IdentityBadId = 0x0000a02a,
    IdentityNoAccountBlob = 0x0000a02b,

    RiskChallengeAction = 0x0000a410,
    RiskDelayAction = 0x0000a411,
    RiskThrottleAction = 0x0000a412,
    RiskAccountLocked = 0x0000a413,
    RiskCsDenied = 0x0000a414,
    RiskDisconnectAccount = 0x0000a415,
    RiskCheckSkipped = 0x0000a416,

    ReportUnavailable = 0x0000afc8,
    ReportTooLarge = 0x0000afc9,
    ReportUnknownType = 0x0000afca,
    ReportAttributeInvalid = 0x0000afcb,
    ReportAttributeQuotaExceeded = 0x0000afcc,
    ReportUnconfirmed = 0x0000afcd,
    ReportNotConnected = 0x0000afce,
    ReportRejected = 0x0000afcf,
    ReportTooManyRequests = 0x0000afd0,

    AccountAlreadyRegisterd = 0x0000bb80,
    AccountNotRegistered = 0x0000bb81,
    AccountRegistrationPending = 0x0000bb82,

    MemcachedClientNoError = 0x00010000,
    MemcachedClientKeyNotFound = 0x00010001,
    MemcachedKeyExists = 0x00010002,
    MemcachedValueToLarge = 0x00010003,
    MemcachedInvalidArgs = 0x00010004,
    MemcachedItemNotStored = 0x00010005,
    MemcachedNonNumericValue = 0x00010006,
    MemcachedWrongServer = 0x00010007,
    MemcachedAuthenticationError = 0x00010008,
    MemcachedAuthenticationContinue = 0x00010009,
    MemcachedUnknownCommand = 0x0001000a,
    MemcachedOutOfMemory = 0x0001000b,
    MemcachedNotSupported = 0x0001000c,
    MemcachedInternalError = 0x0001000d,
    MemcachedTemporaryFailure = 0x0001000e,

    MemcachedClientAlreadyConnected = 0x000186a0,
    MemcachedClientBadConfig = 0x000186a1,
    MemcachedClientNotConnected = 0x000186a2,
    MemcachedClientTimeout = 0x000186a3,
    MemcachedClientAborted = 0x000186a4,

    UtilServerFailedToSerialize = 0x80000064,
    UtilServerDisconnectedFromBattlenet = 0x80000065,
    UtilServerTimedOut = 0x80000066,
    UtilServerNoMeteringData = 0x80000067,
    UtilServerFailPermissionCheck = 0x80000068,
    UtilServerUnknownRealm = 0x80000069,
    UtilServerMissingSessionKey = 0x8000006a,
    UtilServerMissingVirtualRealm = 0x8000006b,
    UtilServerInvalidSessionKey = 0x8000006c,
    UtilServerMissingRealmList = 0x8000006d,
    UtilServerInvalidIdentityArgs = 0x8000006e,
    UtilServerSessionObjectMissing = 0x8000006f,
    UtilServerInvalidBnetSession = 0x80000070,
    UtilServerInvalidVirtualRealm = 0x80000071,
    UtilServerInvalidClientAddress = 0x80000072,
    UtilServerFailedToSerializeResponse = 0x80000073,
    UtilServerUnknownRequest = 0x80000074,
    UtilServerUnableToGenerateJoinTicket = 0x80000075,
    UtilServerUnableToGenerateRealmListTicket = 0x80000076,
    UtilServerAccountDenied = 0x80000077,
    UtilServerInvalidWowAccount = 0x80000078,
    UtilServerUnableToStoreSession = 0x80000079,
    UtilServerSessionAlreadyCreated = 0x8000007a,

    UserServerFailedToSerialize = 0x800000c8,
    UserServerDisconnectedFromUtil = 0x800000c9,
    UserServerSessionDuplicate = 0x800000ca,
    UserServerFailedToDisableBilling = 0x800000cb,
    UserServerPlayerDisconnected = 0x800000cc,
    UserServerFailedToParseAccountState = 0x800000cd,
    UserServerAccountLoadCancelled = 0x800000ce,
    UserServerBadPlatform = 0x800000cf,
    UserServerBadVirtualRealm = 0x800000d0,
    UserServerLocaleRestricted = 0x800000d1,
    UserServerMissingPropass = 0x800000d2,
    UserServerBadWowAccount = 0x800000d3,
    UserServerBadBnetAccount = 0x800000d4,
    UserServerFailedToParseGameAccountState = 0x800000d5,
    UserServerFailedToParseGameTimeRemaining = 0x800000d6,
    UserServerFailedToParseGameSessionInfo = 0x800000d7,
    UserServerAccountStatePoorlyFormed = 0x800000d8,
    UserServerGameAccountStatePoorlyFormed = 0x800000d9,
    UserServerGameTimeRemainingPoorlyFormed = 0x800000da,
    UserServerGameSessionInfoPoorlyFormed = 0x800000db,
    UserServerBadSessionTrackerState = 0x800000dc,
    UserServerFailedToParseCaisInfo = 0x800000dd,
    UserServerGameSessionDisconnected = 0x800000de,
    UserServerVersionMismatch = 0x800000df,
    UserServerAccountSuspended = 0x800000e0,
    UserServerNotPermittedOnRealm = 0x800000e1,
    UserServerLoginFailedConnect = 0x800000e2,

    WowServicesTimedOut = 0x8000012c,
    WowServicesInvalidRealmListTicket = 0x8000012d,
    WowServicesInvalidJoinTicket = 0x8000012e,
    WowServicesInvalidServerAddresses = 0x8000012f,
    WowServicesInvalidSecretBlob = 0x80000130,
    WowServicesNoRealmJoinIpFound = 0x80000131,
    WowServicesDeniedRealmListTicket = 0x80000132,
    WowServicesMissingGameAccount = 0x80000133,
    WowServicesLogonInvalidAuthToken = 0x80000134,
    WowServicesNoAvailableRealms = 0x80000135,
    WowServicesFailedToParseDispatch = 0x80000136,
    WowServicesMissingMeteringFile = 0x80000137,
    WowServicesLoginInvalidContentType = 0x80000138,
    WowServicesLoginUnableToDecode = 0x80000139,
    WowServicesLoginPostError = 0x8000013a,
    WowServicesAuthenticatorParseFailed = 0x8000013b,
    WowServicesLegalParseFailed = 0x8000013c,
    WowServicesLoginAuthenticationParseFailed = 0x8000013d,
    WowSerivcesUserMustAcceptLegal = 0x8000013e,
    WowServicesDisconnected = 0x8000013f,
    WowServicesNoHandlerForDispatch = 0x80000140,
    WowServicesPreDispatchHandlerFailed = 0x80000141,
    WowServicesCriticalStreamingError = 0x80000142,
    WowServicesWorldLoadError = 0x80000143,
    WowServicesLoginFailed = 0x80000144,
    WowServicesLoginFailedOnChallenge = 0x80000145,
    WowServicesNoPrepaidTime = 0x80000146,
    WowServicesSubscriptionExpired = 0x80000147,
    WowServicesCantConnect = 0x80000148,
}

public enum ServiceHash : uint
{
    AccountService = 0x62DA0891u,
    AccountListener = 0x54DFDA17u,
    AuthenticationService = 0x0DECFC01u,
    AuthenticationListener = 0x71240E35u,
    ChallengeListener = 0xBBDA171Fu,
    ClubMembershipService = 0x94B94786u,
    ClubMembershipListener = 0x2B34597Bu,
    ClubService = 0xE273DE0Eu,
    ClubListener = 0x80909D73u,
    ConnectionService = 0x65446991u,
    FriendsService = 0xA3DDB1BDu,
    FriendsListener = 0x6F259A13u,
    GameUtilitiesService = 0x3FC1274Du,
    PresenceService = 0xFA0796FFu,
    PresenceListener = 0x890AB85Fu,
    ReportService = 0x7CAF61C9u,
    ReportServiceV2 = 0x3A4218FBu,
    ResourcesService = 0xECBE75BAu,
    UserManagerService = 0x3E19268Au,
    UserManagerListener = 0xBC872C22u
}
