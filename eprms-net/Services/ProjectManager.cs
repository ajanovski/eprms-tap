/*******************************************************************************
 * Copyright (C) 2021 Vangel V. Ajanovski
 *     
 * This file is part of the EPRMS - Educational Project and Resource 
 * Management System (hereinafter: EPRMS).
 *     
 * EPRMS is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, either version 3 of the License, or
 * (at your option) any later version.
 *     
 * EPRMS is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 *     
 * You should have received a copy of the GNU General Public License
 * along with EPRMS.  If not, see <https://www.gnu.org/licenses/>.
 ******************************************************************************/

using System.Collections.Generic;
using info.ajanovski.eprms.net.Models;

namespace info.ajanovski.eprms.net.Services {

    public interface ProjectManager {

        public List<Project> getAllProjectsOrderByTitle();

        public List<CourseProject> getProjectCourses(Project p);

        public void addCoursesToProject(List<Course> inCourses, Project p);


        public List<Project> getCourseProjectsOrderByTitle(Course selectedCourse);

        public List<Project> getProjectByPerson(long? personId);

    }
}