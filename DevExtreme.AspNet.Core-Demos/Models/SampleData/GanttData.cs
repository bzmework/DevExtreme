﻿using DevExtreme.NETCore.Demos.Models.Gantt;
using System;
using System.Collections.Generic;

namespace DevExtreme.NETCore.Demos.Models.SampleData {
    public partial class SampleData {
        public static readonly IEnumerable<Task> GanttTasks = new[] {
            new Task {
                ID = 1,
                ParentId = 0,
                Title = "Software Development",
                Start = DateTime.Parse("2019-02-21T05:00:00.000Z"),
                End = DateTime.Parse("2019-07-04T12:00:00.000Z"),
                Progress = 31
            },
            new Task {
                ID = 2,
                ParentId = 1,
                Title = "Scope",
                Start = DateTime.Parse("2019-02-21T05:00:00.000Z"),
                End = DateTime.Parse("2019-02-26T09:00:00.000Z"),
                Progress = 60
            },
            new Task {
                ID = 3,
                ParentId = 2,
                Title = "Determine project scope",
                Start = DateTime.Parse("2019-02-21T05:00:00.000Z"),
                End = DateTime.Parse("2019-02-21T09:00:00.000Z"),
                Progress = 100
            },
            new Task {
                ID = 4,
                ParentId = 2,
                Title = "Secure project sponsorship",
                Start = DateTime.Parse("2019-02-21T10:00:00.000Z"),
                End = DateTime.Parse("2019-02-22T09:00:00.000Z"),
                Progress = 100
            },
            new Task {
                ID = 5,
                ParentId = 2,
                Title = "Define preliminary resources",
                Start = DateTime.Parse("2019-02-22T10:00:00.000Z"),
                End = DateTime.Parse("2019-02-25T09:00:00.000Z"),
                Progress = 60
            },
            new Task {
                ID = 6,
                ParentId = 2,
                Title = "Secure core resources",
                Start = DateTime.Parse("2019-02-25T10:00:00.000Z"),
                End = DateTime.Parse("2019-02-26T09:00:00.000Z"),
                Progress = 0
            },
            new Task {
                ID = 7,
                ParentId = 2,
                Title = "Scope complete",
                Start = DateTime.Parse("2019-02-26T09:00:00.000Z"),
                End = DateTime.Parse("2019-02-26T09:00:00.000Z"),
                Progress = 0
            },
            new Task {
                ID = 8,
                ParentId = 1,
                Title = "Analysis/Software Requirements",
                Start = DateTime.Parse("2019-02-26T10:00:00.000Z"),
                End = DateTime.Parse("2019-03-18T09:00:00.000Z"),
                Progress = 80
            },
            new Task {
                ID = 9,
                ParentId = 8,
                Title = "Conduct needs analysis",
                Start = DateTime.Parse("2019-02-26T10:00:00.000Z"),
                End = DateTime.Parse("2019-03-05T09:00:00.000Z"),
                Progress = 100
            },
            new Task {
                ID = 10,
                ParentId = 8,
                Title = "Draft preliminary software specifications",
                Start = DateTime.Parse("2019-03-05T10:00:00.000Z"),
                End = DateTime.Parse("2019-03-08T09:00:00.000Z"),
                Progress = 100
            },
            new Task {
                ID = 11,
                ParentId = 8,
                Title = "Develop preliminary budget",
                Start = DateTime.Parse("2019-03-08T10:00:00.000Z"),
                End = DateTime.Parse("2019-03-12T09:00:00.000Z"),
                Progress = 100
            },
            new Task {
                ID = 12,
                ParentId = 8,
                Title = "Review software specifications/budget with team",
                Start = DateTime.Parse("2019-03-12T10:00:00.000Z"),
                End = DateTime.Parse("2019-03-12T14:00:00.000Z"),
                Progress = 100
            },
            new Task {
                ID = 13,
                ParentId = 8,
                Title = "Incorporate feedback on software specifications",
                Start = DateTime.Parse("2019-03-13T05:00:00.000Z"),
                End = DateTime.Parse("2019-03-13T14:00:00.000Z"),
                Progress = 70
            },
            new Task {
                ID = 14,
                ParentId = 8,
                Title = "Develop delivery timeline",
                Start = DateTime.Parse("2019-03-14T05:00:00.000Z"),
                End = DateTime.Parse("2019-03-14T14:00:00.000Z"),
                Progress = 0
            },
            new Task {
                ID = 15,
                ParentId = 8,
                Title = "Obtain approvals to proceed (concept, timeline, budget)",
                Start = DateTime.Parse("2019-03-15T05:00:00.000Z"),
                End = DateTime.Parse("2019-03-15T09:00:00.000Z"),
                Progress = 0
            },
            new Task {
                ID = 16,
                ParentId = 8,
                Title = "Secure required resources",
                Start = DateTime.Parse("2019-03-15T10:00:00.000Z"),
                End = DateTime.Parse("2019-03-18T09:00:00.000Z"),
                Progress = 0
            },
            new Task {
                ID = 17,
                ParentId = 8,
                Title = "Analysis complete",
                Start = DateTime.Parse("2019-03-18T09:00:00.000Z"),
                End = DateTime.Parse("2019-03-18T09:00:00.000Z"),
                Progress = 0
            },
            new Task {
                ID = 18,
                ParentId = 1,
                Title = "Design",
                Start = DateTime.Parse("2019-03-18T10:00:00.000Z"),
                End = DateTime.Parse("2019-04-05T14:00:00.000Z"),
                Progress = 80
            },
            new Task {
                ID = 19,
                ParentId = 18,
                Title = "Review preliminary software specifications",
                Start = DateTime.Parse("2019-03-18T10:00:00.000Z"),
                End = DateTime.Parse("2019-03-20T09:00:00.000Z"),
                Progress = 100
            },
            new Task {
                ID = 20,
                ParentId = 18,
                Title = "Develop functional specifications",
                Start = DateTime.Parse("2019-03-20T10:00:00.000Z"),
                End = DateTime.Parse("2019-03-27T09:00:00.000Z"),
                Progress = 100
            },
            new Task {
                ID = 21,
                ParentId = 18,
                Title = "Develop prototype based on functional specifications",
                Start = DateTime.Parse("2019-03-27T10:00:00.000Z"),
                End = DateTime.Parse("2019-04-02T09:00:00.000Z"),
                Progress = 100
            },
            new Task {
                ID = 22,
                ParentId = 18,
                Title = "Review functional specifications",
                Start = DateTime.Parse("2019-04-02T10:00:00.000Z"),
                End = DateTime.Parse("2019-04-04T09:00:00.000Z"),
                Progress = 30
            },
            new Task {
                ID = 23,
                ParentId = 18,
                Title = "Incorporate feedback into functional specifications",
                Start = DateTime.Parse("2019-04-04T10:00:00.000Z"),
                End = DateTime.Parse("2019-04-05T09:00:00.000Z"),
                Progress = 0
            },
            new Task {
                ID = 24,
                ParentId = 18,
                Title = "Obtain approval to proceed",
                Start = DateTime.Parse("2019-04-05T10:00:00.000Z"),
                End = DateTime.Parse("2019-04-05T14:00:00.000Z"),
                Progress = 0
            },
            new Task {
                ID = 25,
                ParentId = 18,
                Title = "Design complete",
                Start = DateTime.Parse("2019-04-05T14:00:00.000Z"),
                End = DateTime.Parse("2019-04-05T14:00:00.000Z"),
                Progress = 0
            },
            new Task {
                ID = 26,
                ParentId = 1,
                Title = "Development",
                Start = DateTime.Parse("2019-04-08T05:00:00.000Z"),
                End = DateTime.Parse("2019-05-07T12:00:00.000Z"),
                Progress = 42
            },
            new Task {
                ID = 27,
                ParentId = 26,
                Title = "Review functional specifications",
                Start = DateTime.Parse("2019-04-08T05:00:00.000Z"),
                End = DateTime.Parse("2019-04-08T14:00:00.000Z"),
                Progress = 100
            },
            new Task {
                ID = 28,
                ParentId = 26,
                Title = "Identify modular/tiered design parameters",
                Start = DateTime.Parse("2019-04-09T05:00:00.000Z"),
                End = DateTime.Parse("2019-04-09T14:00:00.000Z"),
                Progress = 100
            },
            new Task {
                ID = 29,
                ParentId = 26,
                Title = "Assign development staff",
                Start = DateTime.Parse("2019-04-10T05:00:00.000Z"),
                End = DateTime.Parse("2019-04-10T14:00:00.000Z"),
                Progress = 100
            },
            new Task {
                ID = 30,
                ParentId = 26,
                Title = "Develop code",
                Start = DateTime.Parse("2019-04-11T05:00:00.000Z"),
                End = DateTime.Parse("2019-05-01T14:00:00.000Z"),
                Progress = 49
            },
            new Task {
                ID = 31,
                ParentId = 26,
                Title = "Developer testing (primary debugging)",
                Start = DateTime.Parse("2019-04-16T12:00:00.000Z"),
                End = DateTime.Parse("2019-05-07T12:00:00.000Z"),
                Progress = 24
            },
            new Task {
                ID = 32,
                ParentId = 26,
                Title = "Development complete",
                Start = DateTime.Parse("2019-05-07T12:00:00.000Z"),
                End = DateTime.Parse("2019-05-07T12:00:00.000Z"),
                Progress = 0
            },
            new Task {
                ID = 33,
                ParentId = 1,
                Title = "Testing",
                Start = DateTime.Parse("2019-04-08T05:00:00.000Z"),
                End = DateTime.Parse("2019-06-13T12:00:00.000Z"),
                Progress = 23
            },
            new Task {
                ID = 34,
                ParentId = 33,
                Title = "Develop unit test plans using product specifications",
                Start = DateTime.Parse("2019-04-08T05:00:00.000Z"),
                End = DateTime.Parse("2019-04-11T14:00:00.000Z"),
                Progress = 100
            },
            new Task {
                ID = 35,
                ParentId = 33,
                Title = "Develop integration test plans using product specifications",
                Start = DateTime.Parse("2019-04-08T05:00:00.000Z"),
                End = DateTime.Parse("2019-04-11T14:00:00.000Z"),
                Progress = 100
            },
            new Task {
                ID = 36,
                ParentId = 33,
                Title = "Unit Testing",
                Start = DateTime.Parse("2019-05-07T12:00:00.000Z"),
                End = DateTime.Parse("2019-05-28T12:00:00.000Z"),
                Progress = 0
            },
            new Task {
                ID = 37,
                ParentId = 36,
                Title = "Review modular code",
                Start = DateTime.Parse("2019-05-07T12:00:00.000Z"),
                End = DateTime.Parse("2019-05-14T12:00:00.000Z"),
                Progress = 0
            },
            new Task {
                ID = 38,
                ParentId = 36,
                Title = "Test component modules to product specifications",
                Start = DateTime.Parse("2019-05-14T12:00:00.000Z"),
                End = DateTime.Parse("2019-05-16T12:00:00.000Z"),
                Progress = 0
            },
            new Task {
                ID = 39,
                ParentId = 36,
                Title = "Identify anomalies to product specifications",
                Start = DateTime.Parse("2019-05-16T12:00:00.000Z"),
                End = DateTime.Parse("2019-05-21T12:00:00.000Z"),
                Progress = 0
            },
            new Task {
                ID = 40,
                ParentId = 36,
                Title = "Modify code",
                Start = DateTime.Parse("2019-05-21T12:00:00.000Z"),
                End = DateTime.Parse("2019-05-24T12:00:00.000Z"),
                Progress = 0
            },
            new Task {
                ID = 41,
                ParentId = 36,
                Title = "Re-test modified code",
                Start = DateTime.Parse("2019-05-24T12:00:00.000Z"),
                End = DateTime.Parse("2019-05-28T12:00:00.000Z"),
                Progress = 0
            },
            new Task {
                ID = 42,
                ParentId = 36,
                Title = "Unit testing complete",
                Start = DateTime.Parse("2019-05-28T12:00:00.000Z"),
                End = DateTime.Parse("2019-05-28T12:00:00.000Z"),
                Progress = 0
            },
            new Task {
                ID = 43,
                ParentId = 33,
                Title = "Integration Testing",
                Start = DateTime.Parse("2019-05-28T12:00:00.000Z"),
                End = DateTime.Parse("2019-06-13T12:00:00.000Z"),
                Progress = 0
            },
            new Task {
                ID = 44,
                ParentId = 43,
                Title = "Test module integration",
                Start = DateTime.Parse("2019-05-28T12:00:00.000Z"),
                End = DateTime.Parse("2019-06-04T12:00:00.000Z"),
                Progress = 0
            },
            new Task {
                ID = 45,
                ParentId = 43,
                Title = "Identify anomalies to specifications",
                Start = DateTime.Parse("2019-06-04T12:00:00.000Z"),
                End = DateTime.Parse("2019-06-06T12:00:00.000Z"),
                Progress = 0
            },
            new Task {
                ID = 46,
                ParentId = 43,
                Title = "Modify code",
                Start = DateTime.Parse("2019-06-06T12:00:00.000Z"),
                End = DateTime.Parse("2019-06-11T12:00:00.000Z"),
                Progress = 0
            },
            new Task {
                ID = 47,
                ParentId = 43,
                Title = "Re-test modified code",
                Start = DateTime.Parse("2019-06-11T12:00:00.000Z"),
                End = DateTime.Parse("2019-06-13T12:00:00.000Z"),
                Progress = 0
            },
            new Task {
                ID = 48,
                ParentId = 43,
                Title = "Integration testing complete",
                Start = DateTime.Parse("2019-06-13T12:00:00.000Z"),
                End = DateTime.Parse("2019-06-13T12:00:00.000Z"),
                Progress = 0
            },
            new Task {
                ID = 49,
                ParentId = 1,
                Title = "Training",
                Start = DateTime.Parse("2019-04-08T05:00:00.000Z"),
                End = DateTime.Parse("2019-06-10T12:00:00.000Z"),
                Progress = 25
            },
            new Task {
                ID = 50,
                ParentId = 49,
                Title = "Develop training specifications for end users",
                Start = DateTime.Parse("2019-04-08T05:00:00.000Z"),
                End = DateTime.Parse("2019-04-10T14:00:00.000Z"),
                Progress = 100
            },
            new Task {
                ID = 51,
                ParentId = 49,
                Title = "Develop training specifications for helpdesk support staff",
                Start = DateTime.Parse("2019-04-08T05:00:00.000Z"),
                End = DateTime.Parse("2019-04-10T14:00:00.000Z"),
                Progress = 100
            },
            new Task {
                ID = 52,
                ParentId = 49,
                Title = "Identify training delivery methodology (computer based training, classroom, etc.)",
                Start = DateTime.Parse("2019-04-08T05:00:00.000Z"),
                End = DateTime.Parse("2019-04-09T14:00:00.000Z"),
                Progress = 100
            },
            new Task {
                ID = 53,
                ParentId = 49,
                Title = "Develop training materials",
                Start = DateTime.Parse("2019-05-07T12:00:00.000Z"),
                End = DateTime.Parse("2019-05-28T12:00:00.000Z"),
                Progress = 0
            },
            new Task {
                ID = 54,
                ParentId = 49,
                Title = "Conduct training usability study",
                Start = DateTime.Parse("2019-05-28T12:00:00.000Z"),
                End = DateTime.Parse("2019-06-03T12:00:00.000Z"),
                Progress = 0
            },
            new Task {
                ID = 55,
                ParentId = 49,
                Title = "Finalize training materials",
                Start = DateTime.Parse("2019-06-03T12:00:00.000Z"),
                End = DateTime.Parse("2019-06-06T12:00:00.000Z"),
                Progress = 0
            },
            new Task {
                ID = 56,
                ParentId = 49,
                Title = "Develop training delivery mechanism",
                Start = DateTime.Parse("2019-06-06T12:00:00.000Z"),
                End = DateTime.Parse("2019-06-10T12:00:00.000Z"),
                Progress = 0
            },
            new Task {
                ID = 57,
                ParentId = 49,
                Title = "Training materials complete",
                Start = DateTime.Parse("2019-06-10T12:00:00.000Z"),
                End = DateTime.Parse("2019-06-10T12:00:00.000Z"),
                Progress = 0
            },
            new Task {
                ID = 58,
                ParentId = 1,
                Title = "Documentation",
                Start = DateTime.Parse("2019-04-08T05:00:00.000Z"),
                End = DateTime.Parse("2019-05-20T09:00:00.000Z"),
                Progress = 0
            },
            new Task {
                ID = 59,
                ParentId = 58,
                Title = "Develop Help specification",
                Start = DateTime.Parse("2019-04-08T05:00:00.000Z"),
                End = DateTime.Parse("2019-04-08T14:00:00.000Z"),
                Progress = 80
            },
            new Task {
                ID = 60,
                ParentId = 58,
                Title = "Develop Help system",
                Start = DateTime.Parse("2019-04-22T10:00:00.000Z"),
                End = DateTime.Parse("2019-05-13T09:00:00.000Z"),
                Progress = 0
            },
            new Task {
                ID = 61,
                ParentId = 58,
                Title = "Review Help documentation",
                Start = DateTime.Parse("2019-05-13T10:00:00.000Z"),
                End = DateTime.Parse("2019-05-16T09:00:00.000Z"),
                Progress = 0
            },
            new Task {
                ID = 62,
                ParentId = 58,
                Title = "Incorporate Help documentation feedback",
                Start = DateTime.Parse("2019-05-16T10:00:00.000Z"),
                End = DateTime.Parse("2019-05-20T09:00:00.000Z"),
                Progress = 0
            },
            new Task {
                ID = 63,
                ParentId = 58,
                Title = "Develop user manuals specifications",
                Start = DateTime.Parse("2019-04-08T05:00:00.000Z"),
                End = DateTime.Parse("2019-04-09T14:00:00.000Z"),
                Progress = 65
            },
            new Task {
                ID = 64,
                ParentId = 58,
                Title = "Develop user manuals",
                Start = DateTime.Parse("2019-04-22T10:00:00.000Z"),
                End = DateTime.Parse("2019-05-13T09:00:00.000Z"),
                Progress = 0
            },
            new Task {
                ID = 65,
                ParentId = 58,
                Title = "Review all user documentation",
                Start = DateTime.Parse("2019-05-13T10:00:00.000Z"),
                End = DateTime.Parse("2019-05-15T09:00:00.000Z"),
                Progress = 0
            },
            new Task {
                ID = 66,
                ParentId = 58,
                Title = "Incorporate user documentation feedback",
                Start = DateTime.Parse("2019-05-15T10:00:00.000Z"),
                End = DateTime.Parse("2019-05-17T09:00:00.000Z"),
                Progress = 0
            },
            new Task {
                ID = 67,
                ParentId = 58,
                Title = "Documentation complete",
                Start = DateTime.Parse("2019-05-20T09:00:00.000Z"),
                End = DateTime.Parse("2019-05-20T09:00:00.000Z"),
                Progress = 0
            },
            new Task {
                ID = 68,
                ParentId = 1,
                Title = "Pilot",
                Start = DateTime.Parse("2019-03-18T10:00:00.000Z"),
                End = DateTime.Parse("2019-06-24T12:00:00.000Z"),
                Progress = 22
            },
            new Task {
                ID = 69,
                ParentId = 68,
                Title = "Identify test group",
                Start = DateTime.Parse("2019-03-18T10:00:00.000Z"),
                End = DateTime.Parse("2019-03-19T09:00:00.000Z"),
                Progress = 100
            },
            new Task {
                ID = 70,
                ParentId = 68,
                Title = "Develop software delivery mechanism",
                Start = DateTime.Parse("2019-03-19T10:00:00.000Z"),
                End = DateTime.Parse("2019-03-20T09:00:00.000Z"),
                Progress = 100
            },
            new Task {
                ID = 71,
                ParentId = 68,
                Title = "Install/deploy software",
                Start = DateTime.Parse("2019-06-13T12:00:00.000Z"),
                End = DateTime.Parse("2019-06-14T12:00:00.000Z"),
                Progress = 0
            },
            new Task {
                ID = 72,
                ParentId = 68,
                Title = "Obtain user feedback",
                Start = DateTime.Parse("2019-06-14T12:00:00.000Z"),
                End = DateTime.Parse("2019-06-21T12:00:00.000Z"),
                Progress = 0
            },
            new Task {
                ID = 73,
                ParentId = 68,
                Title = "Evaluate testing information",
                Start = DateTime.Parse("2019-06-21T12:00:00.000Z"),
                End = DateTime.Parse("2019-06-24T12:00:00.000Z"),
                Progress = 0
            },
            new Task {
                ID = 74,
                ParentId = 68,
                Title = "Pilot complete",
                Start = DateTime.Parse("2019-06-24T12:00:00.000Z"),
                End = DateTime.Parse("2019-06-24T12:00:00.000Z"),
                Progress = 0
            },
            new Task {
                ID = 75,
                ParentId = 1,
                Title = "Deployment",
                Start = DateTime.Parse("2019-06-24T12:00:00.000Z"),
                End = DateTime.Parse("2019-07-01T12:00:00.000Z"),
                Progress = 0
            },
            new Task {
                ID = 76,
                ParentId = 75,
                Title = "Determine final deployment strategy",
                Start = DateTime.Parse("2019-06-24T12:00:00.000Z"),
                End = DateTime.Parse("2019-06-25T12:00:00.000Z"),
                Progress = 0
            },
            new Task {
                ID = 77,
                ParentId = 75,
                Title = "Develop deployment methodology",
                Start = DateTime.Parse("2019-06-25T12:00:00.000Z"),
                End = DateTime.Parse("2019-06-26T12:00:00.000Z"),
                Progress = 0
            },
            new Task {
                ID = 78,
                ParentId = 75,
                Title = "Secure deployment resources",
                Start = DateTime.Parse("2019-06-26T12:00:00.000Z"),
                End = DateTime.Parse("2019-06-27T12:00:00.000Z"),
                Progress = 0
            },
            new Task {
                ID = 79,
                ParentId = 75,
                Title = "Train support staff",
                Start = DateTime.Parse("2019-06-27T12:00:00.000Z"),
                End = DateTime.Parse("2019-06-28T12:00:00.000Z"),
                Progress = 0
            },
            new Task {
                ID = 80,
                ParentId = 75,
                Title = "Deploy software",
                Start = DateTime.Parse("2019-06-28T12:00:00.000Z"),
                End = DateTime.Parse("2019-07-01T12:00:00.000Z"),
                Progress = 0
            },
            new Task {
                ID = 81,
                ParentId = 75,
                Title = "Deployment complete",
                Start = DateTime.Parse("2019-07-01T12:00:00.000Z"),
                End = DateTime.Parse("2019-07-01T12:00:00.000Z"),
                Progress = 0
            },
            new Task {
                ID = 82,
                ParentId = 1,
                Title = "Post Implementation Review",
                Start = DateTime.Parse("2019-07-01T12:00:00.000Z"),
                End = DateTime.Parse("2019-07-04T12:00:00.000Z"),
                Progress = 0
            },
            new Task {
                ID = 83,
                ParentId = 82,
                Title = "Document lessons learned",
                Start = DateTime.Parse("2019-07-01T12:00:00.000Z"),
                End = DateTime.Parse("2019-07-02T12:00:00.000Z"),
                Progress = 0
            },
            new Task {
                ID = 84,
                ParentId = 82,
                Title = "Distribute to team members",
                Start = DateTime.Parse("2019-07-02T12:00:00.000Z"),
                End = DateTime.Parse("2019-07-03T12:00:00.000Z"),
                Progress = 0
            },
            new Task {
                ID = 85,
                ParentId = 82,
                Title = "Create software maintenance team",
                Start = DateTime.Parse("2019-07-03T12:00:00.000Z"),
                End = DateTime.Parse("2019-07-04T12:00:00.000Z"),
                Progress = 0
            },
            new Task {
                ID = 86,
                ParentId = 82,
                Title = "Post implementation review complete",
                Start = DateTime.Parse("2019-07-04T12:00:00.000Z"),
                End = DateTime.Parse("2019-07-04T12:00:00.000Z"),
                Progress = 0
            },
            new Task {
                ID = 87,
                ParentId = 1,
                Title = "Software development template complete",
                Start = DateTime.Parse("2019-07-04T12:00:00.000Z"),
                End = DateTime.Parse("2019-07-04T12:00:00.000Z"),
                Progress = 0
            }
        };

        public static readonly IEnumerable<Dependency> GanttDependencies = new[] {
            new Dependency { ID = 0, PredecessorId = 1, SuccessorId = 2, Type = 0 },
            new Dependency { ID = 1, PredecessorId = 2, SuccessorId = 3, Type = 0 },
            new Dependency { ID = 2, PredecessorId = 3, SuccessorId = 4, Type = 0 },
            new Dependency { ID = 3, PredecessorId = 4, SuccessorId = 5, Type = 0 },
            new Dependency { ID = 4, PredecessorId = 5, SuccessorId = 6, Type = 0 },
            new Dependency { ID = 5, PredecessorId = 6, SuccessorId = 7, Type = 0 },
            new Dependency { ID = 6, PredecessorId = 7, SuccessorId = 8, Type = 0 },
            new Dependency { ID = 7, PredecessorId = 8, SuccessorId = 9, Type = 0 },
            new Dependency { ID = 8, PredecessorId = 9, SuccessorId = 10, Type = 0 },
            new Dependency { ID = 9, PredecessorId = 10, SuccessorId = 11, Type = 0 },
            new Dependency { ID = 10, PredecessorId = 11, SuccessorId = 12, Type = 0 },
            new Dependency { ID = 11, PredecessorId = 12, SuccessorId = 13, Type = 0 },
            new Dependency { ID = 12, PredecessorId = 13, SuccessorId = 14, Type = 0 },
            new Dependency { ID = 13, PredecessorId = 14, SuccessorId = 15, Type = 0 },
            new Dependency { ID = 14, PredecessorId = 15, SuccessorId = 16, Type = 0 },
            new Dependency { ID = 15, PredecessorId = 16, SuccessorId = 17, Type = 0 },
            new Dependency { ID = 16, PredecessorId = 17, SuccessorId = 18, Type = 0 },
            new Dependency { ID = 17, PredecessorId = 18, SuccessorId = 19, Type = 0 },
            new Dependency { ID = 18, PredecessorId = 19, SuccessorId = 20, Type = 0 },
            new Dependency { ID = 19, PredecessorId = 20, SuccessorId = 21, Type = 0 },
            new Dependency { ID = 20, PredecessorId = 21, SuccessorId = 22, Type = 0 },
            new Dependency { ID = 21, PredecessorId = 22, SuccessorId = 23, Type = 0 },
            new Dependency { ID = 22, PredecessorId = 23, SuccessorId = 24, Type = 0 },
            new Dependency { ID = 23, PredecessorId = 24, SuccessorId = 25, Type = 0 },
            new Dependency { ID = 24, PredecessorId = 25, SuccessorId = 26, Type = 0 },
            new Dependency { ID = 25, PredecessorId = 26, SuccessorId = 27, Type = 0 },
            new Dependency { ID = 26, PredecessorId = 27, SuccessorId = 28, Type = 0 },
            new Dependency { ID = 27, PredecessorId = 28, SuccessorId = 29, Type = 0 },
            new Dependency { ID = 28, PredecessorId = 29, SuccessorId = 30, Type = 0 },
            new Dependency { ID = 29, PredecessorId = 30, SuccessorId = 31, Type = 0 },
            new Dependency { ID = 30, PredecessorId = 31, SuccessorId = 32, Type = 0 },
            new Dependency { ID = 31, PredecessorId = 32, SuccessorId = 33, Type = 0 },
            new Dependency { ID = 32, PredecessorId = 33, SuccessorId = 34, Type = 0 },
            new Dependency { ID = 33, PredecessorId = 34, SuccessorId = 35, Type = 0 },
            new Dependency { ID = 34, PredecessorId = 35, SuccessorId = 36, Type = 0 },
            new Dependency { ID = 35, PredecessorId = 36, SuccessorId = 37, Type = 0 },
            new Dependency { ID = 36, PredecessorId = 37, SuccessorId = 38, Type = 0 },
            new Dependency { ID = 37, PredecessorId = 38, SuccessorId = 39, Type = 0 },
            new Dependency { ID = 38, PredecessorId = 39, SuccessorId = 40, Type = 0 },
            new Dependency { ID = 39, PredecessorId = 40, SuccessorId = 41, Type = 0 },
            new Dependency { ID = 40, PredecessorId = 41, SuccessorId = 42, Type = 0 },
            new Dependency { ID = 41, PredecessorId = 42, SuccessorId = 43, Type = 0 },
            new Dependency { ID = 42, PredecessorId = 43, SuccessorId = 44, Type = 0 },
            new Dependency { ID = 43, PredecessorId = 44, SuccessorId = 45, Type = 0 },
            new Dependency { ID = 44, PredecessorId = 45, SuccessorId = 46, Type = 0 },
            new Dependency { ID = 45, PredecessorId = 46, SuccessorId = 47, Type = 0 },
            new Dependency { ID = 46, PredecessorId = 47, SuccessorId = 48, Type = 0 },
            new Dependency { ID = 47, PredecessorId = 48, SuccessorId = 49, Type = 0 },
            new Dependency { ID = 48, PredecessorId = 49, SuccessorId = 50, Type = 0 },
            new Dependency { ID = 49, PredecessorId = 50, SuccessorId = 51, Type = 0 },
            new Dependency { ID = 50, PredecessorId = 51, SuccessorId = 52, Type = 0 },
            new Dependency { ID = 51, PredecessorId = 52, SuccessorId = 53, Type = 0 },
            new Dependency { ID = 52, PredecessorId = 53, SuccessorId = 54, Type = 0 },
            new Dependency { ID = 53, PredecessorId = 54, SuccessorId = 55, Type = 0 },
            new Dependency { ID = 54, PredecessorId = 55, SuccessorId = 56, Type = 0 },
            new Dependency { ID = 55, PredecessorId = 56, SuccessorId = 57, Type = 0 },
            new Dependency { ID = 56, PredecessorId = 57, SuccessorId = 58, Type = 0 },
            new Dependency { ID = 57, PredecessorId = 58, SuccessorId = 59, Type = 0 },
            new Dependency { ID = 58, PredecessorId = 59, SuccessorId = 60, Type = 0 },
            new Dependency { ID = 59, PredecessorId = 60, SuccessorId = 61, Type = 0 },
            new Dependency { ID = 60, PredecessorId = 61, SuccessorId = 62, Type = 0 },
            new Dependency { ID = 61, PredecessorId = 62, SuccessorId = 63, Type = 0 },
            new Dependency { ID = 62, PredecessorId = 63, SuccessorId = 64, Type = 0 },
            new Dependency { ID = 63, PredecessorId = 64, SuccessorId = 65, Type = 0 },
            new Dependency { ID = 64, PredecessorId = 65, SuccessorId = 66, Type = 0 },
            new Dependency { ID = 65, PredecessorId = 66, SuccessorId = 67, Type = 0 },
            new Dependency { ID = 66, PredecessorId = 67, SuccessorId = 68, Type = 0 },
            new Dependency { ID = 67, PredecessorId = 68, SuccessorId = 69, Type = 0 },
            new Dependency { ID = 68, PredecessorId = 69, SuccessorId = 70, Type = 0 },
            new Dependency { ID = 69, PredecessorId = 70, SuccessorId = 71, Type = 0 },
            new Dependency { ID = 70, PredecessorId = 71, SuccessorId = 72, Type = 0 },
            new Dependency { ID = 71, PredecessorId = 72, SuccessorId = 73, Type = 0 },
            new Dependency { ID = 72, PredecessorId = 73, SuccessorId = 74, Type = 0 },
            new Dependency { ID = 73, PredecessorId = 74, SuccessorId = 75, Type = 0 },
            new Dependency { ID = 74, PredecessorId = 75, SuccessorId = 76, Type = 0 },
            new Dependency { ID = 75, PredecessorId = 76, SuccessorId = 77, Type = 0 },
            new Dependency { ID = 76, PredecessorId = 77, SuccessorId = 78, Type = 0 },
            new Dependency { ID = 77, PredecessorId = 78, SuccessorId = 79, Type = 0 },
            new Dependency { ID = 78, PredecessorId = 79, SuccessorId = 80, Type = 0 },
            new Dependency { ID = 79, PredecessorId = 80, SuccessorId = 81, Type = 0 },
            new Dependency { ID = 80, PredecessorId = 81, SuccessorId = 82, Type = 0 },
            new Dependency { ID = 81, PredecessorId = 82, SuccessorId = 83, Type = 0 },
            new Dependency { ID = 82, PredecessorId = 83, SuccessorId = 84, Type = 0 },
            new Dependency { ID = 83, PredecessorId = 84, SuccessorId = 85, Type = 0 },
            new Dependency { ID = 84, PredecessorId = 85, SuccessorId = 86, Type = 0 },
            new Dependency { ID = 85, PredecessorId = 86, SuccessorId = 87, Type = 0 }
        };

        public static readonly IEnumerable<Resource> GanttResources = new[] {
            new Resource { ID = 1, Text = "Management" },
            new Resource { ID = 2, Text = "Project Manager" },
            new Resource { ID = 3, Text = "Analyst" },
            new Resource { ID = 4, Text = "Developer" },
            new Resource { ID = 5, Text = "Testers" },
            new Resource { ID = 6, Text = "Trainers" },
            new Resource { ID = 7, Text = "Technical Communicators" },
            new Resource { ID = 8, Text = "Deployment Team" }
        };

        public static readonly IEnumerable<ResourceAssignment> GanttResourceAssignments = new[] {
            new ResourceAssignment { ID = 0, TaskId = 3, ResourceId = 1 },
            new ResourceAssignment { ID = 1, TaskId = 4, ResourceId = 1 },
            new ResourceAssignment { ID = 2, TaskId = 5, ResourceId = 2 },
            new ResourceAssignment { ID = 3, TaskId = 6, ResourceId = 2 },
            new ResourceAssignment { ID = 4, TaskId = 9, ResourceId = 3 },
            new ResourceAssignment { ID = 5, TaskId = 10, ResourceId = 3 },
            new ResourceAssignment { ID = 6, TaskId = 11, ResourceId = 2 },
            new ResourceAssignment { ID = 7, TaskId = 12, ResourceId = 2 },
            new ResourceAssignment { ID = 8, TaskId = 12, ResourceId = 3 },
            new ResourceAssignment { ID = 9, TaskId = 13, ResourceId = 3 },
            new ResourceAssignment { ID = 10, TaskId = 14, ResourceId = 2 },
            new ResourceAssignment { ID = 11, TaskId = 15, ResourceId = 1 },
            new ResourceAssignment { ID = 12, TaskId = 15, ResourceId = 2 },
            new ResourceAssignment { ID = 13, TaskId = 16, ResourceId = 2 },
            new ResourceAssignment { ID = 14, TaskId = 19, ResourceId = 3 },
            new ResourceAssignment { ID = 15, TaskId = 20, ResourceId = 3 },
            new ResourceAssignment { ID = 16, TaskId = 21, ResourceId = 3 },
            new ResourceAssignment { ID = 17, TaskId = 22, ResourceId = 1 },
            new ResourceAssignment { ID = 18, TaskId = 23, ResourceId = 1 },
            new ResourceAssignment { ID = 19, TaskId = 24, ResourceId = 1 },
            new ResourceAssignment { ID = 20, TaskId = 24, ResourceId = 2 },
            new ResourceAssignment { ID = 21, TaskId = 27, ResourceId = 4 },
            new ResourceAssignment { ID = 22, TaskId = 28, ResourceId = 4 },
            new ResourceAssignment { ID = 23, TaskId = 29, ResourceId = 4 },
            new ResourceAssignment { ID = 24, TaskId = 30, ResourceId = 4 },
            new ResourceAssignment { ID = 25, TaskId = 31, ResourceId = 4 },
            new ResourceAssignment { ID = 26, TaskId = 34, ResourceId = 5 },
            new ResourceAssignment { ID = 27, TaskId = 35, ResourceId = 5 },
            new ResourceAssignment { ID = 28, TaskId = 37, ResourceId = 5 },
            new ResourceAssignment { ID = 29, TaskId = 38, ResourceId = 5 },
            new ResourceAssignment { ID = 30, TaskId = 39, ResourceId = 5 },
            new ResourceAssignment { ID = 31, TaskId = 40, ResourceId = 5 },
            new ResourceAssignment { ID = 32, TaskId = 41, ResourceId = 5 },
            new ResourceAssignment { ID = 33, TaskId = 44, ResourceId = 5 },
            new ResourceAssignment { ID = 34, TaskId = 45, ResourceId = 5 },
            new ResourceAssignment { ID = 35, TaskId = 46, ResourceId = 5 },
            new ResourceAssignment { ID = 36, TaskId = 47, ResourceId = 5 },
            new ResourceAssignment { ID = 37, TaskId = 50, ResourceId = 6 },
            new ResourceAssignment { ID = 38, TaskId = 51, ResourceId = 6 },
            new ResourceAssignment { ID = 39, TaskId = 52, ResourceId = 6 },
            new ResourceAssignment { ID = 40, TaskId = 53, ResourceId = 6 },
            new ResourceAssignment { ID = 41, TaskId = 54, ResourceId = 6 },
            new ResourceAssignment { ID = 42, TaskId = 55, ResourceId = 6 },
            new ResourceAssignment { ID = 43, TaskId = 56, ResourceId = 6 },
            new ResourceAssignment { ID = 44, TaskId = 59, ResourceId = 7 },
            new ResourceAssignment { ID = 45, TaskId = 60, ResourceId = 7 },
            new ResourceAssignment { ID = 46, TaskId = 61, ResourceId = 7 },
            new ResourceAssignment { ID = 47, TaskId = 62, ResourceId = 7 },
            new ResourceAssignment { ID = 48, TaskId = 63, ResourceId = 7 },
            new ResourceAssignment { ID = 49, TaskId = 64, ResourceId = 7 },
            new ResourceAssignment { ID = 50, TaskId = 65, ResourceId = 7 },
            new ResourceAssignment { ID = 51, TaskId = 66, ResourceId = 7 },
            new ResourceAssignment { ID = 52, TaskId = 69, ResourceId = 2 },
            new ResourceAssignment { ID = 53, TaskId = 71, ResourceId = 8 },
            new ResourceAssignment { ID = 54, TaskId = 72, ResourceId = 8 },
            new ResourceAssignment { ID = 55, TaskId = 73, ResourceId = 8 },
            new ResourceAssignment { ID = 56, TaskId = 76, ResourceId = 8 },
            new ResourceAssignment { ID = 57, TaskId = 77, ResourceId = 8 },
            new ResourceAssignment { ID = 58, TaskId = 78, ResourceId = 8 },
            new ResourceAssignment { ID = 59, TaskId = 79, ResourceId = 8 },
            new ResourceAssignment { ID = 60, TaskId = 80, ResourceId = 8 },
            new ResourceAssignment { ID = 61, TaskId = 83, ResourceId = 2 },
            new ResourceAssignment { ID = 62, TaskId = 84, ResourceId = 2 },
            new ResourceAssignment { ID = 63, TaskId = 85, ResourceId = 2 }
        };
    }
}
