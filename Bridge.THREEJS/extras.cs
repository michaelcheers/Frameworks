using Bridge;
using System;
using Bridge.Html5;
using RegExp = Bridge.Text.RegularExpressions.Regex;
using number = System.Double;
using Number = System.Double;


	[External]
	public class AudioContext : EventTarget
	{
#pragma warning disable CS0626
		[FieldProperty]
		public extern double CurrentTime { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern AudioDestinationNode Destination { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern AudioListener Listener { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern double SampleRate { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern string State { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern AnalyserNode CreateAnalyser ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern BiquadFilterNode CreateBiquadFilter ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern AudioBuffer CreateBuffer (double numberOfChannels, double length, double sampleRate);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern AudioBufferSourceNode CreateBufferSource ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern ChannelMergerNode CreateChannelMerger (double numberOfInputs = default(double));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern ChannelSplitterNode CreateChannelSplitter (double numberOfOutputs = default(double));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern ConvolverNode CreateConvolver ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern DelayNode CreateDelay (double maxDelayTime = default(double));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern DynamicsCompressorNode CreateDynamicsCompressor ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern GainNode CreateGain ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern MediaElementAudioSourceNode CreateMediaElementSource (HTMLMediaElement mediaElement);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern OscillatorNode CreateOscillator ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern PannerNode CreatePanner ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern PeriodicWave CreatePeriodicWave (Float32Array real, Float32Array imag);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern ScriptProcessorNode CreateScriptProcessor (double bufferSize = default(double), double numberOfInputChannels = default(double), double numberOfOutputChannels = default(double));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern StereoPannerNode CreateStereoPanner ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern WaveShaperNode CreateWaveShaper ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern void DecodeAudioData (ArrayBuffer audioData, DecodeSuccessCallback successCallback, DecodeErrorCallback errorCallback = default(DecodeErrorCallback));
#pragma warning restore CS0626
#pragma warning disable CS0824
		extern AudioContext ();
#pragma warning restore CS0824
	}
	[External]
	public delegate void DecodeSuccessCallback (AudioBuffer decodedData);
	[External]
	public delegate void DecodeErrorCallback ();
	[External]
	public class AudioBuffer
	{
#pragma warning disable CS0626
		[FieldProperty]
		public extern double Duration { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern double Length { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern double NumberOfChannels { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern double SampleRate { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern Float32Array GetChannelData (double channel);
#pragma warning restore CS0626
#pragma warning disable CS0824
		extern AudioBuffer ();
#pragma warning restore CS0824
	}
	[External]
	public class WaveShaperNode : AudioNode
	{
#pragma warning disable CS0626
		[FieldProperty]
		public extern Float32Array Curve { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern string Oversample { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
		extern WaveShaperNode ();
#pragma warning restore CS0824
	}
	[External]
	public class StereoPannerNode : AudioNode
	{
#pragma warning disable CS0626
		[FieldProperty]
		public extern AudioParam Pan { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
		extern StereoPannerNode ();
#pragma warning restore CS0824
	}
	[External]
	public delegate object onaudioprocessDelegate (AudioProcessingEvent ev);
	[External]
	public delegate object addEventListenerParam11Delegate (AudioProcessingEvent ev);
	[External]
	public class ScriptProcessorNode : AudioNode
	{
#pragma warning disable CS0626
		[FieldProperty]
		public extern double BufferSize { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern onaudioprocessDelegate Onaudioprocess { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern void AddEventListener (string type, addEventListenerParam11Delegate listener, bool useCapture = default(bool));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern void AddEventListener (string type, Any<EventListener, EventListenerObject> listener, bool useCapture = default(bool));
#pragma warning restore CS0626
#pragma warning disable CS0824
		extern ScriptProcessorNode ();
#pragma warning restore CS0824
	}
	[External]
	public class AudioProcessingEvent : Event
	{
#pragma warning disable CS0626
		[FieldProperty]
		public extern AudioBuffer InputBuffer { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern AudioBuffer OutputBuffer { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern double PlaybackTime { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
		extern AudioProcessingEvent ();
#pragma warning restore CS0824
	}
	[External]
	public class AudioNode : EventTarget
	{
#pragma warning disable CS0626
		[FieldProperty]
		public extern double ChannelCount { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern string ChannelCountMode { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern string ChannelInterpretation { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern AudioContext Context { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern double NumberOfInputs { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern double NumberOfOutputs { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern void Connect (AudioNode destination, double output = default(double), double input = default(double));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern void Disconnect (double output = default(double));
#pragma warning restore CS0626
#pragma warning disable CS0824
		extern AudioNode ();
#pragma warning restore CS0824
	}
	[External]
	public class GainNode : AudioNode
	{
#pragma warning disable CS0626
		[FieldProperty]
		public extern AudioParam Gain { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
		extern GainNode ();
#pragma warning restore CS0824
	}
	[External]
	public class AudioListener
	{
#pragma warning disable CS0626
		[FieldProperty]
		public extern double DopplerFactor { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern double SpeedOfSound { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern void SetOrientation (double x, double y, double z, double xUp, double yUp, double zUp);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern void SetPosition (double x, double y, double z);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern void SetVelocity (double x, double y, double z);
#pragma warning restore CS0626
#pragma warning disable CS0824
		extern AudioListener ();
#pragma warning restore CS0824
	}
	[External]
	public class AudioDestinationNode : AudioNode
	{
#pragma warning disable CS0626
		[FieldProperty]
		public extern double MaxChannelCount { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
		extern AudioDestinationNode ();
#pragma warning restore CS0824
	}
	[External]
	public class AnalyserNode : AudioNode
	{
#pragma warning disable CS0626
		[FieldProperty]
		public extern double FftSize { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern double FrequencyBinCount { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern double MaxDecibels { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern double MinDecibels { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern double SmoothingTimeConstant { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern void GetByteFrequencyData (Uint8Array array);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern void GetByteTimeDomainData (Uint8Array array);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern void GetFloatFrequencyData (Float32Array array);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern void GetFloatTimeDomainData (Float32Array array);
#pragma warning restore CS0626
#pragma warning disable CS0824
		extern AnalyserNode ();
#pragma warning restore CS0824
	}
	[External]
	public class BiquadFilterNode : AudioNode
	{
#pragma warning disable CS0626
		[FieldProperty]
		[Name(false)]
		public extern AudioParam Q { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern AudioParam Detune { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern AudioParam Frequency { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern AudioParam Gain { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern string Type { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern void GetFrequencyResponse (Float32Array frequencyHz, Float32Array magResponse, Float32Array phaseResponse);
#pragma warning restore CS0626
#pragma warning disable CS0824
		extern BiquadFilterNode ();
#pragma warning restore CS0824
	}
	[External]
	public delegate object onendedDelegate (Event ev);
	[External]
	public class AudioBufferSourceNode : AudioNode
	{
#pragma warning disable CS0626
		[FieldProperty]
		public extern AudioBuffer Buffer { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern bool Loop { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern double LoopEnd { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern double LoopStart { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern onendedDelegate Onended { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern AudioParam PlaybackRate { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern void Start (double when = default(double), double offset = default(double), double duration = default(double));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern void Stop (double when = default(double));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern void AddEventListener (string type, addEventListenerParam11Delegate listener, bool useCapture = default(bool));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern void AddEventListener (string type, Any<EventListener, EventListenerObject> listener, bool useCapture = default(bool));
#pragma warning restore CS0626
#pragma warning disable CS0824
		extern AudioBufferSourceNode ();
#pragma warning restore CS0824
	}
	[External]
	public class ChannelMergerNode : AudioNode
	{
#pragma warning disable CS0824
		extern ChannelMergerNode ();
#pragma warning restore CS0824
	}
	[External]
	public class ChannelSplitterNode : AudioNode
	{
#pragma warning disable CS0824
		extern ChannelSplitterNode ();
#pragma warning restore CS0824
	}
	[External]
	public class ConvolverNode : AudioNode
	{
#pragma warning disable CS0626
		[FieldProperty]
		public extern AudioBuffer Buffer { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern bool Normalize { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
		extern ConvolverNode ();
#pragma warning restore CS0824
	}
	[External]
	public class DelayNode : AudioNode
	{
#pragma warning disable CS0626
		[FieldProperty]
		public extern AudioParam DelayTime { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
		extern DelayNode ();
#pragma warning restore CS0824
	}
	[External]
	public class AudioParam
	{
#pragma warning disable CS0626
		[FieldProperty]
		public extern double DefaultValue { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern double Value { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern void CancelScheduledValues (double startTime);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern void ExponentialRampToValueAtTime (double value, double endTime);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern void LinearRampToValueAtTime (double value, double endTime);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern void SetTargetAtTime (double target, double startTime, double timeConstant);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern void SetValueAtTime (double value, double startTime);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern void SetValueCurveAtTime (Float32Array values, double startTime, double duration);
#pragma warning restore CS0626
#pragma warning disable CS0824
		extern AudioParam ();
#pragma warning restore CS0824
	}
	[External]
	public class DynamicsCompressorNode : AudioNode
	{
#pragma warning disable CS0626
		[FieldProperty]
		public extern AudioParam Attack { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern AudioParam Knee { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern AudioParam Ratio { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern AudioParam Reduction { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern AudioParam Release { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern AudioParam Threshold { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
		extern DynamicsCompressorNode ();
#pragma warning restore CS0824
	}
	[External]
	public class ArrayLike<T>
	{
#pragma warning disable CS0626
		[FieldProperty]
		public extern double Length { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern T this [double index] { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
		extern ArrayLike ();
#pragma warning restore CS0824
	}
	[External]
	public delegate object onmsneedkeyDelegate (MSMediaKeyNeededEvent ev);
	[External]
	public class HTMLMediaElement : HTMLElement
	{
#pragma warning disable CS0626
		[FieldProperty]
		public extern AudioTrackList AudioTracks { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern bool Autoplay { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern TimeRanges Buffered { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern bool Controls { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern string CurrentSrc { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern double CurrentTime { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern bool DefaultMuted { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern double DefaultPlaybackRate { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern double Duration { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern bool Ended { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern MediaError Error { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern bool Loop { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern string MsAudioCategory { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern string MsAudioDeviceType { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern MSGraphicsTrust MsGraphicsTrustStatus { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern MSMediaKeys MsKeys { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern bool MsPlayToDisabled { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern string MsPlayToPreferredSourceUri { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern bool MsPlayToPrimary { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern object MsPlayToSource { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern bool MsRealTime { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern bool Muted { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern double NetworkState { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern onmsneedkeyDelegate Onmsneedkey { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern bool Paused { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern double PlaybackRate { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern TimeRanges Played { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern string Preload { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern double ReadyState { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern TimeRanges Seekable { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern bool Seeking { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern string Src { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern TextTrackList TextTracks { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern VideoTrackList VideoTracks { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern double Volume { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		[Name(false)]
		public extern double HAVE_CURRENT_DATA { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		[Name(false)]
		public extern double HAVE_ENOUGH_DATA { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		[Name(false)]
		public extern double HAVE_FUTURE_DATA { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		[Name(false)]
		public extern double HAVE_METADATA { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		[Name(false)]
		public extern double HAVE_NOTHING { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		[Name(false)]
		public extern double NETWORK_EMPTY { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		[Name(false)]
		public extern double NETWORK_IDLE { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		[Name(false)]
		public extern double NETWORK_LOADING { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		[Name(false)]
		public extern double NETWORK_NO_SOURCE { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern TextTrack AddTextTrack (string kind, string label = default(string), string language = default(string));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern string CanPlayType (string type);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern void Load ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern void MsClearEffects ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern object MsGetAsCastingSource ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern void MsInsertAudioEffect (string activatableClassId, bool effectRequired, object config = default(object));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern void MsSetMediaKeys (MSMediaKeys mediaKeys);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern void MsSetMediaProtectionManager (object mediaProtectionManager = default(object));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern void Pause ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern void Play ();
#pragma warning restore CS0626
#pragma warning disable CS0824
		extern HTMLMediaElement ();
#pragma warning restore CS0824
	}
	[External]
	public class MSMediaKeys
	{
#pragma warning disable CS0626
		[FieldProperty]
		public extern string KeySystem { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern MSMediaKeySession CreateSession (string type, Uint8Array initData, Uint8Array cdmData = default(Uint8Array));
#pragma warning restore CS0626
#pragma warning disable CS0824
		extern MSMediaKeys ();
#pragma warning restore CS0824
	}
	[External]
	public class MSMediaKeySession : EventTarget
	{
#pragma warning disable CS0626
		[FieldProperty]
		public extern MSMediaKeyError Error { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern string KeySystem { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern string SessionId { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern void Close ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern void Update (Uint8Array key);
#pragma warning restore CS0626
#pragma warning disable CS0824
		extern MSMediaKeySession ();
#pragma warning restore CS0824
	}
	[External]
	public class MSMediaKeyError
	{
#pragma warning disable CS0626
		[FieldProperty]
		public extern double Code { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern double SystemCode { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		[Name(false)]
		public extern double MS_MEDIA_KEYERR_CLIENT { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		[Name(false)]
		public extern double MS_MEDIA_KEYERR_DOMAIN { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		[Name(false)]
		public extern double MS_MEDIA_KEYERR_HARDWARECHANGE { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		[Name(false)]
		public extern double MS_MEDIA_KEYERR_OUTPUT { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		[Name(false)]
		public extern double MS_MEDIA_KEYERR_SERVICE { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		[Name(false)]
		public extern double MS_MEDIA_KEYERR_UNKNOWN { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
		extern MSMediaKeyError ();
#pragma warning restore CS0824
	}
	[External]
	public delegate object onaddtrackDelegate (TrackEvent ev);
	[External]
	public delegate object onchangeDelegate (Event ev);
	[External]
	public delegate object onremovetrackDelegate (TrackEvent ev);
	[External]
	public delegate object addEventListenerParam11Delegate1 (TrackEvent ev);
	[External]
	public delegate object addEventListenerParam11Delegate2 (Event ev);
	[External]
	public delegate object addEventListenerParam11Delegate3 (TrackEvent ev);
	[External]
	public class VideoTrackList : EventTarget
	{
#pragma warning disable CS0626
		[FieldProperty]
		public extern double Length { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern onaddtrackDelegate Onaddtrack { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern onchangeDelegate Onchange { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern onremovetrackDelegate Onremovetrack { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern double SelectedIndex { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern VideoTrack GetTrackById (string id);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern VideoTrack item (double index);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern void AddEventListener (string type, addEventListenerParam11Delegate1 listener, bool useCapture = default(bool));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern void AddEventListener (string type, addEventListenerParam11Delegate2 listener, bool useCapture = default(bool));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern void AddEventListener (string type, addEventListenerParam11Delegate3 listener, bool useCapture = default(bool));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern void AddEventListener (string type, Any<EventListener, EventListenerObject> listener, bool useCapture = default(bool));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern VideoTrack this [double index] { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
		extern VideoTrackList ();
#pragma warning restore CS0824
	}
	[External]
	public class VideoTrack
	{
#pragma warning disable CS0626
		[FieldProperty]
		public extern string Id { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern string Kind { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern string Label { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern string Language { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern bool Selected { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern SourceBuffer SourceBuffer { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
		extern VideoTrack ();
#pragma warning restore CS0824
	}
	[External]
	public class SourceBuffer : EventTarget
	{
#pragma warning disable CS0626
		[FieldProperty]
		public extern double AppendWindowEnd { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern double AppendWindowStart { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern AudioTrackList AudioTracks { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern TimeRanges Buffered { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern string Mode { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern double TimestampOffset { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern bool Updating { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern VideoTrackList VideoTracks { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern void Abort ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern void AppendBuffer (Any<ArrayBuffer, ArrayBufferView> data);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern void AppendStream (MSStream stream, double maxSize = default(double));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern void Remove (double start, double end);
#pragma warning restore CS0626
#pragma warning disable CS0824
		extern SourceBuffer ();
#pragma warning restore CS0824
	}
	[External]
	public class MSStream
	{
#pragma warning disable CS0626
		[FieldProperty]
		public extern string Type { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern void MsClose ();
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern object MsDetachStream ();
#pragma warning restore CS0626
#pragma warning disable CS0824
		extern MSStream ();
#pragma warning restore CS0824
	}
	[External]
	public class TimeRanges
	{
#pragma warning disable CS0626
		[FieldProperty]
		public extern double Length { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern double End (double index);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern double Start (double index);
#pragma warning restore CS0626
#pragma warning disable CS0824
		extern TimeRanges ();
#pragma warning restore CS0824
	}
	[External]
	public delegate object addEventListenerParam11Delegate4 (TrackEvent ev);
	[External]
	public delegate object addEventListenerParam11Delegate5 (Event ev);
	[External]
	public delegate object addEventListenerParam11Delegate6 (TrackEvent ev);
	[External]
	public class AudioTrackList : EventTarget
	{
#pragma warning disable CS0626
		[FieldProperty]
		public extern double Length { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern onaddtrackDelegate Onaddtrack { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern onchangeDelegate Onchange { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern onremovetrackDelegate Onremovetrack { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern AudioTrack GetTrackById (string id);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern AudioTrack item (double index);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern void AddEventListener (string type, addEventListenerParam11Delegate4 listener, bool useCapture = default(bool));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern void AddEventListener (string type, addEventListenerParam11Delegate5 listener, bool useCapture = default(bool));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern void AddEventListener (string type, addEventListenerParam11Delegate6 listener, bool useCapture = default(bool));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern void AddEventListener (string type, Any<EventListener, EventListenerObject> listener, bool useCapture = default(bool));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern AudioTrack this [double index] { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
		extern AudioTrackList ();
#pragma warning restore CS0824
	}
	[External]
	public class AudioTrack
	{
#pragma warning disable CS0626
		[FieldProperty]
		public extern bool Enabled { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern string Id { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern string Kind { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern string Label { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern string Language { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern SourceBuffer SourceBuffer { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
		extern AudioTrack ();
#pragma warning restore CS0824
	}
	[External]
	public delegate void EventListener (Event evt);
	[ObjectLiteral]
	public class JSONEventListenerObject : EventListenerObject
	{
	[External]
	public delegate void handleEventDelegate (Event evt);

#pragma warning disable CS0626
		public extern void HandleEvent (Event evt);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern handleEventDelegate handleEvent { get; set; }
#pragma warning restore CS0626
	}
	[External]
	public interface EventListenerObject
	{
		void HandleEvent (Event evt);
	}
	[External]
	public class MediaElementAudioSourceNode : AudioNode
	{
#pragma warning disable CS0824
		extern MediaElementAudioSourceNode ();
#pragma warning restore CS0824
	}
	[External]
	public delegate object addEventListenerParam11Delegate7 (Event ev);
	[External]
	public class OscillatorNode : AudioNode
	{
#pragma warning disable CS0626
		[FieldProperty]
		public extern AudioParam Detune { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern AudioParam Frequency { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern onendedDelegate Onended { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern string Type { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern void SetPeriodicWave (PeriodicWave periodicWave);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern void Start (double when = default(double));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern void Stop (double when = default(double));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern void AddEventListener (string type, addEventListenerParam11Delegate7 listener, bool useCapture = default(bool));
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern void AddEventListener (string type, Any<EventListener, EventListenerObject> listener, bool useCapture = default(bool));
#pragma warning restore CS0626
#pragma warning disable CS0824
		extern OscillatorNode ();
#pragma warning restore CS0824
	}
	[External]
	public class PeriodicWave
	{
#pragma warning disable CS0824
		extern PeriodicWave ();
#pragma warning restore CS0824
	}
	[External]
	public class TrackEvent : Event
	{
#pragma warning disable CS0626
		[FieldProperty]
		public extern object Track { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
		extern TrackEvent ();
#pragma warning restore CS0824
	}
	[External]
	public class PannerNode : AudioNode
	{
#pragma warning disable CS0626
		[FieldProperty]
		public extern double ConeInnerAngle { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern double ConeOuterAngle { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern double ConeOuterGain { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern string DistanceModel { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern double MaxDistance { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern string PanningModel { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern double RefDistance { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern double RolloffFactor { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern void SetOrientation (double x, double y, double z);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern void SetPosition (double x, double y, double z);
#pragma warning restore CS0626
#pragma warning disable CS0626
		public extern void SetVelocity (double x, double y, double z);
#pragma warning restore CS0626
#pragma warning disable CS0824
		extern PannerNode ();
#pragma warning restore CS0824
	}
	[External]
	public class MSMediaKeyNeededEvent : Event
	{
#pragma warning disable CS0626
		[FieldProperty]
		public extern Uint8Array InitData { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
		extern MSMediaKeyNeededEvent ();
#pragma warning restore CS0824
	}
	[External]
	public class MSGraphicsTrust
	{
#pragma warning disable CS0626
		[FieldProperty]
		public extern bool ConstrictionActive { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0626
		[FieldProperty]
		public extern string Status { get; set; }
#pragma warning restore CS0626
#pragma warning disable CS0824
		extern MSGraphicsTrust ();
#pragma warning restore CS0824
	}
