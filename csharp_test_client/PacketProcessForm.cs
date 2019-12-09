﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace csharp_test_client
{
    public partial class mainForm
    {
        Dictionary<PACKET_ID, Action<byte[]>> PacketFuncDic = new Dictionary<PACKET_ID, Action<byte[]>>();

        void SetPacketHandler()
        {
            PacketFuncDic.Add(PACKET_ID.PACKET_ID_ECHO, PacketProcess_Echo);
            PacketFuncDic.Add(PACKET_ID.PACKET_ID_SIMPLE_CHAT, PacketProcess_SimpleChat);

            PacketFuncDic.Add(PACKET_ID.RES_LOBBY_LOGIN, PacketProcess_LoginResponse);
            PacketFuncDic.Add(PACKET_ID.RES_ROOM_ENTER, PacketProcess_RoomEnterResponse);
            PacketFuncDic.Add(PACKET_ID.RES_ROOM_LEAVE, PacketProcess_RoomLeaveResponse);
            PacketFuncDic.Add(PACKET_ID.RES_ROOM_CHAT, PacketProcess_RoomChatResponse);            
            PacketFuncDic.Add(PACKET_ID.NTF_ROOM_CHAT, PacketProcess_RoomChatNotify);            
        }

        void PacketProcess(NetLib.PacketData packet)
        {
            var packetType = (PACKET_ID)packet.PacketID;
            //DevLog.Write("Packet Error:  PacketID:{packet.PacketID.ToString()},  Error: {(ERROR_CODE)packet.Result}");
            //DevLog.Write("RawPacket: " + packet.PacketID.ToString() + ", " + PacketDump.Bytes(packet.BodyData));

            if (PacketFuncDic.ContainsKey(packetType))
            {
                PacketFuncDic[packetType](packet.BodyData);
            }
            else
            {
                DevLog.Write("Unknown Packet Id: " + packet.PacketID.ToString());
            }         
        }

        void PacketProcess_Echo(byte[] bodyData)
        {
            DevLog.Write($"Echo 받음:  {bodyData.Length}");
        }

        void PacketProcess_SimpleChat(byte[] bodyData)
        {
            var stringData = Encoding.UTF8.GetString(bodyData);
            DevLog.Write($"SimpleChat 받음: {stringData}");
        }

        void PacketProcess_ErrorNotify(byte[] bodyData)
        {
            var notifyPkt = new ErrorNtfPacket();
            notifyPkt.FromBytes(bodyData);

            DevLog.Write($"에러 통보 받음:  {notifyPkt.Error}");
        }


        void PacketProcess_LoginResponse(byte[] bodyData)
        {
            //var responsePkt = new LoginResPacket();
            //responsePkt.FromBytes(bodyData);

            //DevLog.Write($"로그인 결과:  {(ERROR_CODE)responsePkt.Result}");
        }


        void PacketProcess_RoomEnterResponse(byte[] bodyData)
        {
            //var responsePkt = new RoomEnterResPacket();
            //responsePkt.FromBytes(bodyData);

            //DevLog.Write($"방 입장 결과:  {(ERROR_CODE)responsePkt.Result}");
        }

        void PacketProcess_RoomUserListNotify(byte[] bodyData)
        {
            //var notifyPkt = new RoomUserListNtfPacket();
            //notifyPkt.FromBytes(bodyData);

            //for (int i = 0; i < notifyPkt.UserCount; ++i)
            //{
            //    AddRoomUserList(notifyPkt.UserUniqueIdList[i], notifyPkt.UserIDList[i]);
            //}

            //DevLog.Write($"방의 기존 유저 리스트 받음");
        }

        void PacketProcess_RoomNewUserNotify(byte[] bodyData)
        {
            //var notifyPkt = new RoomNewUserNtfPacket();
            //notifyPkt.FromBytes(bodyData);

            //AddRoomUserList(notifyPkt.UserUniqueId, notifyPkt.UserID);
            
            //DevLog.Write($"방에 새로 들어온 유저 받음");
        }


        void PacketProcess_RoomLeaveResponse(byte[] bodyData)
        {
            //var responsePkt = new RoomLeaveResPacket();
            //responsePkt.FromBytes(bodyData);

            //DevLog.Write($"방 나가기 결과:  {(ERROR_CODE)responsePkt.Result}");
        }

        void PacketProcess_RoomLeaveUserNotify(byte[] bodyData)
        {
            //var notifyPkt = new RoomLeaveUserNtfPacket();
            //notifyPkt.FromBytes(bodyData);

            //RemoveRoomUserList(notifyPkt.UserUniqueId);

            //DevLog.Write($"방에서 나간 유저 받음");
        }


        void PacketProcess_RoomChatResponse(byte[] bodyData)
        {
            //var responsePkt = new RoomChatResPacket();
            //responsePkt.FromBytes(bodyData);

            //var errorCode = (ERROR_CODE)responsePkt.Result;
            //var msg = $"방 채팅 요청 결과:  {(ERROR_CODE)responsePkt.Result}";
            //if (errorCode == ERROR_CODE.ERROR_NONE)
            //{
            //    DevLog.Write(msg, LOG_LEVEL.ERROR);
            //}
            //else
            //{
            //    AddRoomChatMessageList(0, msg);
            //}
        }


        void PacketProcess_RoomChatNotify(byte[] bodyData)
        {
            //var responsePkt = new RoomChatNtfPacket();
            //responsePkt.FromBytes(bodyData);

            //AddRoomChatMessageList(responsePkt.UserUniqueId, responsePkt.Message);
        }

        void AddRoomChatMessageList(Int64 userUniqueId, string msgssage)
        {
            var msg = $"{userUniqueId}:  {msgssage}";

            if (listBoxRoomChatMsg.Items.Count > 512)
            {
                listBoxRoomChatMsg.Items.Clear();
            }

            listBoxRoomChatMsg.Items.Add(msg);
            listBoxRoomChatMsg.SelectedIndex = listBoxRoomChatMsg.Items.Count - 1;
        }


        void PacketProcess_RoomRelayNotify(byte[] bodyData)
        {
            //var notifyPkt = new RoomRelayNtfPacket();
            //notifyPkt.FromBytes(bodyData);

            //var stringData = Encoding.UTF8.GetString(notifyPkt.RelayData);
            //DevLog.Write($"방에서 릴레이 받음. {notifyPkt.UserUniqueId} - {stringData}");
        }
    }
}
