using GalaSoft.MvvmLight;
using ArkSAP.Behaviors;
using ArkSAP.Model;
using System.Collections.Generic;
using System.Windows.Input;

namespace ArkSAP.ViewModel
{
	public interface IMainViewModel : IHavePassword
	{
		string Host { get; set; }
		int Port { get; set; }
		ICommand ConnectCommand { get; }
		ICommand DisconnectCommand { get; }
		ICommand ExecuteCommand { get; }
		ICommand ClearLogsCommand { get; }
		bool IsWorking { get; }
		bool IsConnected { get; }
		string MessageBody { get; set; }
		bool IsPanelOpen { get; set; }
		IEnumerable<CommunicationChunk> CommunicationChunks { get; }
		bool IsError { get; }
		string ErrorMessage { get; }
	}
}
