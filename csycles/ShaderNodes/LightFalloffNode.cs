﻿/**
Copyright 2014 Robert McNeel and Associates

Licensed under the Apache License, Version 2.0 (the "License");
you may not use this file except in compliance with the License.
You may obtain a copy of the License at

http://www.apache.org/licenses/LICENSE-2.0

Unless required by applicable law or agreed to in writing, software
distributed under the License is distributed on an "AS IS" BASIS,
WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
See the License for the specific language governing permissions and
limitations under the License.
**/

using System.Xml;
using ccl.ShaderNodes.Sockets;
using ccl.Attributes;

namespace ccl.ShaderNodes
{
	public class LightFalloffOutputs : Outputs
	{
		public Float4Socket Quadratic { get; set; }
		public Float4Socket Linear { get; set; }
		public Float4Socket Constant { get; set; }

		public LightFalloffOutputs(ShaderNode parentNode)
		{
			Quadratic = new Float4Socket(parentNode, "Quadratic");
			AddSocket(Quadratic);
			Linear = new Float4Socket(parentNode, "Linear");
			AddSocket(Linear);
			Constant = new Float4Socket(parentNode, "Constant");
			AddSocket(Constant);
		}
	}

	public class LightFalloffInputs : Inputs
	{
		public FloatSocket Strength { get; set; }
		public FloatSocket Smooth { get; set; }
		public LightFalloffInputs(ShaderNode parentNode)
		{
			Strength = new FloatSocket(parentNode, "Strength");
			AddSocket(Strength);
			Smooth = new FloatSocket(parentNode, "Smooth");
			AddSocket(Smooth);
		}
	}

	[ShaderNode("light_falloff")]
	public class LightFalloffNode : ShaderNode
	{
		public LightFalloffInputs ins { get { return (LightFalloffInputs)inputs; } }
		public LightFalloffOutputs outs { get { return (LightFalloffOutputs)outputs; } }

		public LightFalloffNode() : this("a light fall-off node") { }
		public LightFalloffNode(string name) :
			base(ShaderNodeType.LightFalloff, name)
		{
			inputs = new LightFalloffInputs(this);
			outputs = new LightFalloffOutputs(this);
		}

		internal override void ParseXml(XmlReader xmlNode)
		{
			Utilities.Instance.get_float(ins.Smooth, xmlNode.GetAttribute("smooth"));
			Utilities.Instance.get_float(ins.Strength, xmlNode.GetAttribute("strength"));
		}
	}
}
