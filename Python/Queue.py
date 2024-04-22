// Pre-req:  pip install azure-storage-queue azure-identity
import os, uuid
from azure.identity import DefaultAzureCredential
from azure.storage.queue import QueueServiceClient, QueueClient, QueueMessage, BinaryBase64DecodePolicy, BinaryBase64EncodePolicy

try:
    print("Azure Queue storage - Python quickstart sample")

    # Create a unique name for the queue
    queue_name = "msgs"
    connect_str = ""

    # Setup Base64 encoding and decoding functions
    base64_queue_client = QueueClient.from_connection_string(
                            conn_str=connect_str, queue_name=queue_name,
                            message_encode_policy = BinaryBase64EncodePolicy(),
                            message_decode_policy = BinaryBase64DecodePolicy()
                        )

    # account_url = "https://rspbdisplaystorage.queue.core.windows.net"
    # default_credential = DefaultAzureCredential()

    # Create the QueueClient object
    # We'll use this object to create and interact with the queue
    # queue_client = QueueClient(account_url, queue_name=queue_name ,credential=default_credential)
    queue_client = QueueClient.from_connection_string(connect_str, queue_name)

    print("\nAdding messages to the queue...")

    # Send several messages to the queue
    queue_client.send_message(u"First message")
    queue_client.send_message(u"Second message")
    saved_message = queue_client.send_message(u"Third message")
except Exception as ex:
    print('Exception:')
    print(ex)
