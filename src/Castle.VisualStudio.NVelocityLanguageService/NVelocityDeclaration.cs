// Copyright 2007-2010 Jonathon Rossi - http://jonorossi.com/
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// 
//     http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.

namespace Castle.VisualStudio.NVelocityLanguageService
{
    using Castle.NVelocity.Ast;

    public class NVelocityDeclaration
    {
        private readonly string _name;
        private readonly NVIdNode _idNode;
        private readonly IntelliSenseIcon _icon;

        public NVelocityDeclaration(string name, NVIdNode idNode, IntelliSenseIcon icon)
        {
            _name = name;
            _idNode = idNode;
            _icon = icon;
        }

        public string Name
        {
            get { return _name; }
        }

        public NVIdNode IdNode
        {
            get { return _idNode; }
        }

        public IntelliSenseIcon Icon
        {
            get { return _icon; }
        }
    }
}