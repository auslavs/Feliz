import Admonition from '@theme/Admonition';
import React from 'react';
import { ExternalRefBanner } from '../MarkdownFetcher';

export function MaterialIconThemeNuget(props) {
	return (<svg xmlns="http://www.w3.org/2000/svg" width={32} height={32} viewBox="0 0 32 32" {...props}><circle cx={5} cy={5} r={3} fill="#0288d1"></circle><path fill="#0288d1" d="M8 14v10a6 6 0 0 0 6 6h10a6 6 0 0 0 6-6V14a6 6 0 0 0-6-6H14a6 6 0 0 0-6 6m7 4a3 3 0 1 1 3-3a3 3 0 0 1-3 3m7 8a4 4 0 1 1 4-4a4 4 0 0 1-4 4"></path></svg>);
}

export default function NugetPkgAdmonition({href, docs, source, name, children}: {href: string, name: string, docs?: string, source?: string, children?: React.ReactNode}) {
  return (
    <ExternalRefBanner name={name} github={source} docs={docs} nuget={href} mdSource='' children={children} />
  );
}
