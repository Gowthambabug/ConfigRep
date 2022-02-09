// <auto-generated>
// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for
// license information.
//
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.
// </auto-generated>

namespace Microsoft.Azure.Batch.Protocol
{
    using Microsoft.Rest;
    using Microsoft.Rest.Azure;
    using Models;
    using System.IO;
    using System.Threading;
    using System.Threading.Tasks;

    /// <summary>
    /// Extension methods for FileOperations.
    /// </summary>
    public static partial class FileOperationsExtensions
    {
            /// <summary>
            /// Deletes the specified Task file from the Compute Node where the Task ran.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobId'>
            /// The ID of the Job that contains the Task.
            /// </param>
            /// <param name='taskId'>
            /// The ID of the Task whose file you want to delete.
            /// </param>
            /// <param name='filePath'>
            /// The path to the Task file or directory that you want to delete.
            /// </param>
            /// <param name='recursive'>
            /// Whether to delete children of a directory. If the filePath parameter
            /// represents a directory instead of a file, you can set recursive to true to
            /// delete the directory and all of the files and subdirectories in it. If
            /// recursive is false then the directory must be empty or deletion will fail.
            /// </param>
            /// <param name='fileDeleteFromTaskOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static FileDeleteFromTaskHeaders DeleteFromTask(this IFileOperations operations, string jobId, string taskId, string filePath, bool? recursive = default(bool?), FileDeleteFromTaskOptions fileDeleteFromTaskOptions = default(FileDeleteFromTaskOptions))
            {
                return operations.DeleteFromTaskAsync(jobId, taskId, filePath, recursive, fileDeleteFromTaskOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified Task file from the Compute Node where the Task ran.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobId'>
            /// The ID of the Job that contains the Task.
            /// </param>
            /// <param name='taskId'>
            /// The ID of the Task whose file you want to delete.
            /// </param>
            /// <param name='filePath'>
            /// The path to the Task file or directory that you want to delete.
            /// </param>
            /// <param name='recursive'>
            /// Whether to delete children of a directory. If the filePath parameter
            /// represents a directory instead of a file, you can set recursive to true to
            /// delete the directory and all of the files and subdirectories in it. If
            /// recursive is false then the directory must be empty or deletion will fail.
            /// </param>
            /// <param name='fileDeleteFromTaskOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FileDeleteFromTaskHeaders> DeleteFromTaskAsync(this IFileOperations operations, string jobId, string taskId, string filePath, bool? recursive = default(bool?), FileDeleteFromTaskOptions fileDeleteFromTaskOptions = default(FileDeleteFromTaskOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteFromTaskWithHttpMessagesAsync(jobId, taskId, filePath, recursive, fileDeleteFromTaskOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Returns the content of the specified Task file.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobId'>
            /// The ID of the Job that contains the Task.
            /// </param>
            /// <param name='taskId'>
            /// The ID of the Task whose file you want to retrieve.
            /// </param>
            /// <param name='filePath'>
            /// The path to the Task file that you want to get the content of.
            /// </param>
            /// <param name='fileGetFromTaskOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static Stream GetFromTask(this IFileOperations operations, string jobId, string taskId, string filePath, FileGetFromTaskOptions fileGetFromTaskOptions = default(FileGetFromTaskOptions))
            {
                return operations.GetFromTaskAsync(jobId, taskId, filePath, fileGetFromTaskOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the content of the specified Task file.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobId'>
            /// The ID of the Job that contains the Task.
            /// </param>
            /// <param name='taskId'>
            /// The ID of the Task whose file you want to retrieve.
            /// </param>
            /// <param name='filePath'>
            /// The path to the Task file that you want to get the content of.
            /// </param>
            /// <param name='fileGetFromTaskOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Stream> GetFromTaskAsync(this IFileOperations operations, string jobId, string taskId, string filePath, FileGetFromTaskOptions fileGetFromTaskOptions = default(FileGetFromTaskOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                var _result = await operations.GetFromTaskWithHttpMessagesAsync(jobId, taskId, filePath, fileGetFromTaskOptions, null, cancellationToken).ConfigureAwait(false);
                _result.Request.Dispose();
                return _result.Body;
            }

            /// <summary>
            /// Gets the properties of the specified Task file.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobId'>
            /// The ID of the Job that contains the Task.
            /// </param>
            /// <param name='taskId'>
            /// The ID of the Task whose file you want to get the properties of.
            /// </param>
            /// <param name='filePath'>
            /// The path to the Task file that you want to get the properties of.
            /// </param>
            /// <param name='fileGetPropertiesFromTaskOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static FileGetPropertiesFromTaskHeaders GetPropertiesFromTask(this IFileOperations operations, string jobId, string taskId, string filePath, FileGetPropertiesFromTaskOptions fileGetPropertiesFromTaskOptions = default(FileGetPropertiesFromTaskOptions))
            {
                return operations.GetPropertiesFromTaskAsync(jobId, taskId, filePath, fileGetPropertiesFromTaskOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the properties of the specified Task file.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobId'>
            /// The ID of the Job that contains the Task.
            /// </param>
            /// <param name='taskId'>
            /// The ID of the Task whose file you want to get the properties of.
            /// </param>
            /// <param name='filePath'>
            /// The path to the Task file that you want to get the properties of.
            /// </param>
            /// <param name='fileGetPropertiesFromTaskOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FileGetPropertiesFromTaskHeaders> GetPropertiesFromTaskAsync(this IFileOperations operations, string jobId, string taskId, string filePath, FileGetPropertiesFromTaskOptions fileGetPropertiesFromTaskOptions = default(FileGetPropertiesFromTaskOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetPropertiesFromTaskWithHttpMessagesAsync(jobId, taskId, filePath, fileGetPropertiesFromTaskOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Deletes the specified file from the Compute Node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='poolId'>
            /// The ID of the Pool that contains the Compute Node.
            /// </param>
            /// <param name='nodeId'>
            /// The ID of the Compute Node from which you want to delete the file.
            /// </param>
            /// <param name='filePath'>
            /// The path to the file or directory that you want to delete.
            /// </param>
            /// <param name='recursive'>
            /// Whether to delete children of a directory. If the filePath parameter
            /// represents a directory instead of a file, you can set recursive to true to
            /// delete the directory and all of the files and subdirectories in it. If
            /// recursive is false then the directory must be empty or deletion will fail.
            /// </param>
            /// <param name='fileDeleteFromComputeNodeOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static FileDeleteFromComputeNodeHeaders DeleteFromComputeNode(this IFileOperations operations, string poolId, string nodeId, string filePath, bool? recursive = default(bool?), FileDeleteFromComputeNodeOptions fileDeleteFromComputeNodeOptions = default(FileDeleteFromComputeNodeOptions))
            {
                return operations.DeleteFromComputeNodeAsync(poolId, nodeId, filePath, recursive, fileDeleteFromComputeNodeOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Deletes the specified file from the Compute Node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='poolId'>
            /// The ID of the Pool that contains the Compute Node.
            /// </param>
            /// <param name='nodeId'>
            /// The ID of the Compute Node from which you want to delete the file.
            /// </param>
            /// <param name='filePath'>
            /// The path to the file or directory that you want to delete.
            /// </param>
            /// <param name='recursive'>
            /// Whether to delete children of a directory. If the filePath parameter
            /// represents a directory instead of a file, you can set recursive to true to
            /// delete the directory and all of the files and subdirectories in it. If
            /// recursive is false then the directory must be empty or deletion will fail.
            /// </param>
            /// <param name='fileDeleteFromComputeNodeOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FileDeleteFromComputeNodeHeaders> DeleteFromComputeNodeAsync(this IFileOperations operations, string poolId, string nodeId, string filePath, bool? recursive = default(bool?), FileDeleteFromComputeNodeOptions fileDeleteFromComputeNodeOptions = default(FileDeleteFromComputeNodeOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.DeleteFromComputeNodeWithHttpMessagesAsync(poolId, nodeId, filePath, recursive, fileDeleteFromComputeNodeOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Returns the content of the specified Compute Node file.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='poolId'>
            /// The ID of the Pool that contains the Compute Node.
            /// </param>
            /// <param name='nodeId'>
            /// The ID of the Compute Node that contains the file.
            /// </param>
            /// <param name='filePath'>
            /// The path to the Compute Node file that you want to get the content of.
            /// </param>
            /// <param name='fileGetFromComputeNodeOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static Stream GetFromComputeNode(this IFileOperations operations, string poolId, string nodeId, string filePath, FileGetFromComputeNodeOptions fileGetFromComputeNodeOptions = default(FileGetFromComputeNodeOptions))
            {
                return operations.GetFromComputeNodeAsync(poolId, nodeId, filePath, fileGetFromComputeNodeOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Returns the content of the specified Compute Node file.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='poolId'>
            /// The ID of the Pool that contains the Compute Node.
            /// </param>
            /// <param name='nodeId'>
            /// The ID of the Compute Node that contains the file.
            /// </param>
            /// <param name='filePath'>
            /// The path to the Compute Node file that you want to get the content of.
            /// </param>
            /// <param name='fileGetFromComputeNodeOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<Stream> GetFromComputeNodeAsync(this IFileOperations operations, string poolId, string nodeId, string filePath, FileGetFromComputeNodeOptions fileGetFromComputeNodeOptions = default(FileGetFromComputeNodeOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                var _result = await operations.GetFromComputeNodeWithHttpMessagesAsync(poolId, nodeId, filePath, fileGetFromComputeNodeOptions, null, cancellationToken).ConfigureAwait(false);
                _result.Request.Dispose();
                return _result.Body;
            }

            /// <summary>
            /// Gets the properties of the specified Compute Node file.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='poolId'>
            /// The ID of the Pool that contains the Compute Node.
            /// </param>
            /// <param name='nodeId'>
            /// The ID of the Compute Node that contains the file.
            /// </param>
            /// <param name='filePath'>
            /// The path to the Compute Node file that you want to get the properties of.
            /// </param>
            /// <param name='fileGetPropertiesFromComputeNodeOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static FileGetPropertiesFromComputeNodeHeaders GetPropertiesFromComputeNode(this IFileOperations operations, string poolId, string nodeId, string filePath, FileGetPropertiesFromComputeNodeOptions fileGetPropertiesFromComputeNodeOptions = default(FileGetPropertiesFromComputeNodeOptions))
            {
                return operations.GetPropertiesFromComputeNodeAsync(poolId, nodeId, filePath, fileGetPropertiesFromComputeNodeOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Gets the properties of the specified Compute Node file.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='poolId'>
            /// The ID of the Pool that contains the Compute Node.
            /// </param>
            /// <param name='nodeId'>
            /// The ID of the Compute Node that contains the file.
            /// </param>
            /// <param name='filePath'>
            /// The path to the Compute Node file that you want to get the properties of.
            /// </param>
            /// <param name='fileGetPropertiesFromComputeNodeOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<FileGetPropertiesFromComputeNodeHeaders> GetPropertiesFromComputeNodeAsync(this IFileOperations operations, string poolId, string nodeId, string filePath, FileGetPropertiesFromComputeNodeOptions fileGetPropertiesFromComputeNodeOptions = default(FileGetPropertiesFromComputeNodeOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.GetPropertiesFromComputeNodeWithHttpMessagesAsync(poolId, nodeId, filePath, fileGetPropertiesFromComputeNodeOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Headers;
                }
            }

            /// <summary>
            /// Lists the files in a Task's directory on its Compute Node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobId'>
            /// The ID of the Job that contains the Task.
            /// </param>
            /// <param name='taskId'>
            /// The ID of the Task whose files you want to list.
            /// </param>
            /// <param name='recursive'>
            /// Whether to list children of the Task directory. This parameter can be used
            /// in combination with the filter parameter to list specific type of files.
            /// </param>
            /// <param name='fileListFromTaskOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static IPage<NodeFile> ListFromTask(this IFileOperations operations, string jobId, string taskId, bool? recursive = default(bool?), FileListFromTaskOptions fileListFromTaskOptions = default(FileListFromTaskOptions))
            {
                return operations.ListFromTaskAsync(jobId, taskId, recursive, fileListFromTaskOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the files in a Task's directory on its Compute Node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='jobId'>
            /// The ID of the Job that contains the Task.
            /// </param>
            /// <param name='taskId'>
            /// The ID of the Task whose files you want to list.
            /// </param>
            /// <param name='recursive'>
            /// Whether to list children of the Task directory. This parameter can be used
            /// in combination with the filter parameter to list specific type of files.
            /// </param>
            /// <param name='fileListFromTaskOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<NodeFile>> ListFromTaskAsync(this IFileOperations operations, string jobId, string taskId, bool? recursive = default(bool?), FileListFromTaskOptions fileListFromTaskOptions = default(FileListFromTaskOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListFromTaskWithHttpMessagesAsync(jobId, taskId, recursive, fileListFromTaskOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all of the files in Task directories on the specified Compute Node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='poolId'>
            /// The ID of the Pool that contains the Compute Node.
            /// </param>
            /// <param name='nodeId'>
            /// The ID of the Compute Node whose files you want to list.
            /// </param>
            /// <param name='recursive'>
            /// Whether to list children of a directory.
            /// </param>
            /// <param name='fileListFromComputeNodeOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static IPage<NodeFile> ListFromComputeNode(this IFileOperations operations, string poolId, string nodeId, bool? recursive = default(bool?), FileListFromComputeNodeOptions fileListFromComputeNodeOptions = default(FileListFromComputeNodeOptions))
            {
                return operations.ListFromComputeNodeAsync(poolId, nodeId, recursive, fileListFromComputeNodeOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all of the files in Task directories on the specified Compute Node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='poolId'>
            /// The ID of the Pool that contains the Compute Node.
            /// </param>
            /// <param name='nodeId'>
            /// The ID of the Compute Node whose files you want to list.
            /// </param>
            /// <param name='recursive'>
            /// Whether to list children of a directory.
            /// </param>
            /// <param name='fileListFromComputeNodeOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<NodeFile>> ListFromComputeNodeAsync(this IFileOperations operations, string poolId, string nodeId, bool? recursive = default(bool?), FileListFromComputeNodeOptions fileListFromComputeNodeOptions = default(FileListFromComputeNodeOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListFromComputeNodeWithHttpMessagesAsync(poolId, nodeId, recursive, fileListFromComputeNodeOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists the files in a Task's directory on its Compute Node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='fileListFromTaskNextOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static IPage<NodeFile> ListFromTaskNext(this IFileOperations operations, string nextPageLink, FileListFromTaskNextOptions fileListFromTaskNextOptions = default(FileListFromTaskNextOptions))
            {
                return operations.ListFromTaskNextAsync(nextPageLink, fileListFromTaskNextOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists the files in a Task's directory on its Compute Node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='fileListFromTaskNextOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<NodeFile>> ListFromTaskNextAsync(this IFileOperations operations, string nextPageLink, FileListFromTaskNextOptions fileListFromTaskNextOptions = default(FileListFromTaskNextOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListFromTaskNextWithHttpMessagesAsync(nextPageLink, fileListFromTaskNextOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

            /// <summary>
            /// Lists all of the files in Task directories on the specified Compute Node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='fileListFromComputeNodeNextOptions'>
            /// Additional parameters for the operation
            /// </param>
            public static IPage<NodeFile> ListFromComputeNodeNext(this IFileOperations operations, string nextPageLink, FileListFromComputeNodeNextOptions fileListFromComputeNodeNextOptions = default(FileListFromComputeNodeNextOptions))
            {
                return operations.ListFromComputeNodeNextAsync(nextPageLink, fileListFromComputeNodeNextOptions).GetAwaiter().GetResult();
            }

            /// <summary>
            /// Lists all of the files in Task directories on the specified Compute Node.
            /// </summary>
            /// <param name='operations'>
            /// The operations group for this extension method.
            /// </param>
            /// <param name='nextPageLink'>
            /// The NextLink from the previous successful call to List operation.
            /// </param>
            /// <param name='fileListFromComputeNodeNextOptions'>
            /// Additional parameters for the operation
            /// </param>
            /// <param name='cancellationToken'>
            /// The cancellation token.
            /// </param>
            public static async Task<IPage<NodeFile>> ListFromComputeNodeNextAsync(this IFileOperations operations, string nextPageLink, FileListFromComputeNodeNextOptions fileListFromComputeNodeNextOptions = default(FileListFromComputeNodeNextOptions), CancellationToken cancellationToken = default(CancellationToken))
            {
                using (var _result = await operations.ListFromComputeNodeNextWithHttpMessagesAsync(nextPageLink, fileListFromComputeNodeNextOptions, null, cancellationToken).ConfigureAwait(false))
                {
                    return _result.Body;
                }
            }

    }
}